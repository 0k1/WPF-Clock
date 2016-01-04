using WPF_Clock.Animation;
using WPF_Clock.Model;
using System.Windows;
using System.Windows.Media;

namespace WPF_Clock
{
    public class NumberTweener
    {
        private const float FramesPerTransition = 60.0f;
        private const float StopPercentage = 0.7f;

        private int _frame = 0, _currentNumber = 0, _nextNumber = 1;
        private int _height, _width;
        private Evaluator _pointEvaluator;
        private float[,] _controlPoints;

        public PathGeometry PathData { get; private set; }

        public NumberTweener(int height, int width)
        {
            PathData = new PathGeometry();
            _height = height;
            _width = width;
            _pointEvaluator = new Evaluator();
        }

        public void GetFrame(int? number = null)
        {
            if (number != null)
            {
                _nextNumber = (int)number;
            }
            float ratio = _frame < StopPercentage * FramesPerTransition ? 0 :
                            (_frame - StopPercentage * FramesPerTransition) / (FramesPerTransition * (1 - StopPercentage));
            _controlPoints = _pointEvaluator.evaluate(ratio,
                                    NumberUtils.getControlPointsFor(_currentNumber), NumberUtils.getControlPointsFor(_nextNumber));

            if (_controlPoints == null) return;

            int length = _controlPoints.Length / _controlPoints.Rank;

            float minDimen = _height > _width ? _width : _height;

            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = new Point(minDimen * _controlPoints[0, 0], minDimen * _controlPoints[0, 1]);

            for (int i = 1; i < length; i += 3)
            {
                BezierSegment bezierSegment = new BezierSegment();
                bezierSegment.Point1 = new Point(minDimen * _controlPoints[i, 0], minDimen * _controlPoints[i, 1]);
                bezierSegment.Point2 = new Point(minDimen * _controlPoints[i + 1, 0], minDimen * _controlPoints[i + 1, 1]);
                bezierSegment.Point3 = new Point(minDimen * _controlPoints[i + 2, 0], minDimen * _controlPoints[i + 2, 1]);

                pathFigure.Segments.Add(bezierSegment);
            }
            PathData.Figures.Clear();
            PathData.Figures.Add(pathFigure);

            if (_frame < FramesPerTransition)
                _frame++;
            else
            {
                _frame = 0;
                _currentNumber = _nextNumber;
            }
        }
    }
}
