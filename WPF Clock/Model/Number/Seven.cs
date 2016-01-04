using WPF_Clock.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clock.Model.Number
{
    public class Seven : Figure
    {
        private static float[,] POINTS = {
            {0.259668508287293f, 0.116022099447514f},   {0.259668508287293f, 0.116022099447514f},   {0.87292817679558f,  0.116022099447514f},
            {0.87292817679558f,  0.116022099447514f},   {0.87292817679558f,  0.116022099447514f},   {0.7f,               0.422099447513812f},
            {0.7f,               0.422099447513812f},   {0.7f,               0.422099447513812f},   {0.477348066298343f, 0.733149171270718f},
            {0.477348066298343f, 0.733149171270718f},   {0.477348066298343f, 0.733149171270718f},   {0.25414364640884f,  1f},
            {0.25414364640884f,  1f}
        };

        private static Seven INSTANCE = new Seven();

        protected Seven() : base(POINTS)
        {
        }

        public static Seven getInstance()
        {
            return INSTANCE;
        }
    }
}
