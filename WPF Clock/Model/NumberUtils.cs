using WPF_Clock.Model.Number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clock.Model
{
    public class NumberUtils
    {
        public static float[,] getControlPointsFor(int start)
        {
            switch (start)
            {
                case (-1):
                    return Null.getInstance().getControlPoints();
                case 0:
                    return Zero.getInstance().getControlPoints();
                case 1:
                    return One.getInstance().getControlPoints();
                case 2:
                    return Two.getInstance().getControlPoints();
                case 3:
                    return Three.getInstance().getControlPoints();
                case 4:
                    return Four.getInstance().getControlPoints();
                case 5:
                    return Five.getInstance().getControlPoints();
                case 6:
                    return Six.getInstance().getControlPoints();
                case 7:
                    return Seven.getInstance().getControlPoints();
                case 8:
                    return Eight.getInstance().getControlPoints();
                case 9:
                    return Nine.getInstance().getControlPoints();
                default:
                    throw new ArgumentException("Unsupported number requested");
            }
        }
    }
}
