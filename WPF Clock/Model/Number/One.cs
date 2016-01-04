using WPF_Clock.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clock.Model.Number
{
    public class One : Figure
    {
        private static float[,] POINTS = {
            {0.425414364640884f, 0.113259668508287f},   {0.425414364640884f, 0.113259668508287f},   {0.577348066298343f, 0.113259668508287f},
            {0.577348066298343f, 0.113259668508287f},   {0.577348066298343f, 0.113259668508287f},   {0.577348066298343f, 1f},
            {0.577348066298343f, 1f},                   {0.577348066298343f, 1f},                   {0.577348066298343f, 1f},
            {0.577348066298343f, 1f},                   {0.577348066298343f, 1f},                   {0.577348066298343f, 1f},
            {0.577348066298343f, 1f}
        };

        private static One INSTANCE = new One();

        protected One() : base(POINTS)
        {
        }

        public static One getInstance()
        {
            return INSTANCE;
        }
    }
}
