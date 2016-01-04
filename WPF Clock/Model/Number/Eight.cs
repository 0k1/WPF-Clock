using WPF_Clock.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clock.Model.Number
{
    public class Eight : Figure
    {
        private static float[,] POINTS = {
            {0.558011049723757f, 0.530386740331492f},   {0.243093922651934f, 0.524861878453039f},   {0.243093922651934f, 0.104972375690608f},
            {0.558011049723757f, 0.104972375690608f},   {0.850828729281768f, 0.104972375690608f},   {0.850828729281768f, 0.530386740331492f},
            {0.558011049723757f, 0.530386740331492f},   {0.243093922651934f, 0.530386740331492f},   {0.198895027624309f, 0.988950276243094f},
            {0.558011049723757f, 0.988950276243094f},   {0.850828729281768f, 0.988950276243094f},   {0.850828729281768f, 0.530386740331492f},
            {0.558011049723757f, 0.530386740331492f}
        };

        private static Eight INSTANCE = new Eight();

        protected Eight() : base(POINTS)
        {
        }

        public static Eight getInstance()
        {
            return INSTANCE;
        }
    }
}
