using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clock.Model.Core
{
    public abstract class Figure
    {
        public const int NO_VALUE = -1;

        protected int pointsCount = NO_VALUE;

        //A chained sequence of points P0,P1,P2,P3/0,P1,P2,P3/0,...
        protected float[,] controlPoints = null;

        protected Figure(float[,] controlPoints)
        {
            this.controlPoints = controlPoints;
            this.pointsCount = ((controlPoints.Length / controlPoints.Rank) + 2) / 3;
        }

        public int getPointsCount()
        {
            return pointsCount;
        }

        public float[,] getControlPoints()
        {
            return controlPoints;
        }
    }
}
