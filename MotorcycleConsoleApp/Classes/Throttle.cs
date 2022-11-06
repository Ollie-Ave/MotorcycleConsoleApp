using MotorcycleConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConsoleApp.Classes
{
    internal class Throttle : Engine
    {
        public int ThrottleState { get; set; } = 0;

        public void PullThrottle(int ThrottlePosition)
        {
            ThrottleState = ThrottlePosition;
        }

        public void ReleaseThrottle()
        {
            ThrottleState = 0;
        }
    }
}
