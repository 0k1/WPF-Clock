using WPF_Clock.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clock.Model.Number
{
    public class Null : Figure
    {
        private static float[,] POINTS = {
            {0.5f, 0.5f},   {0.5f, 0.5f},   {0.5f, 0.5f},
            {0.5f, 0.5f},   {0.5f, 0.5f},   {0.5f, 0.5f},
            {0.5f, 0.5f},                   {0.5f, 0.5f},                   {0.5f, 0.5f},
            {0.5f, 0.5f},                   {0.5f, 0.5f},                   {0.5f, 0.5f},
            {0.5f, 0.5f}
        };

        private static Null INSTANCE = new Null();

        protected Null() : base(POINTS)
        {
        }

        public static Null getInstance()
        {
            return INSTANCE;
        }
    }
}
