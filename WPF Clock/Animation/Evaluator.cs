using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clock.Animation
{
    public class Evaluator
    {
        private float[,] _cachedPoints = null;

        public float[,] evaluate(float fraction, float[,] startValue, float[,] endValue)
        {
            int pointsCount = startValue.Length / startValue.Rank;
            initCache(pointsCount);

            for (int i = 0; i < pointsCount; i++)
            {
                _cachedPoints[i, 0] = startValue[i, 0] + fraction * (endValue[i, 0] - startValue[i, 0]);
                _cachedPoints[i, 1] = startValue[i, 1] + fraction * (endValue[i, 1] - startValue[i, 1]);
            }

            return _cachedPoints;
        }

        private void initCache(int pointsCount)
        {
            if (_cachedPoints == null || (_cachedPoints.Length / _cachedPoints.Rank) != pointsCount)
            {
                _cachedPoints = new float[pointsCount, 2];
            }
        }
    }
}
