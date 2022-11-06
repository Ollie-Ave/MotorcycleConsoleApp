using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleConsole.Classes
{
    internal class Throttle : Motorcycle
    {
        private int ThrottlePosition { get; set; }

        public int Idle { get; set; } = 10;

        public void AdjustThrottle(int tp)
        {
            ThrottlePosition = tp;
        }

        public int GetThrottleState()
        {
            return ThrottlePosition;
        }
    }
}
