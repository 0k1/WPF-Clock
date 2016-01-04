using WPF_Clock.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clock.Model.Number
{
    public class Four : Figure
    {
        private static float[,] POINTS = {
            {0.856353591160221f, 0.806629834254144f},   {0.856353591160221f, 0.806629834254144f},   {0.237569060773481f, 0.806629834254144f},
            {0.237569060773481f, 0.806629834254144f},   {0.237569060773481f, 0.806629834254144f},   {0.712707182320442f, 0.138121546961326f},
            {0.712707182320442f, 0.138121546961326f},   {0.712707182320442f, 0.138121546961326f},   {0.712707182320442f, 0.806629834254144f},
            {0.712707182320442f, 0.806629834254144f},   {0.712707182320442f, 0.806629834254144f},   {0.712707182320442f, 0.988950276243094f},
            {0.712707182320442f, 0.988950276243094f}

        };

        private static Four INSTANCE = new Four();

        protected Four() : base(POINTS)
        {
        }

        public static Four getInstance()
        {
            return INSTANCE;
        }
    }
}
