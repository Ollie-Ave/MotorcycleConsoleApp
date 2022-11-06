using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace VehicleConsole.Classes
{
    internal class Engine
    {
        public bool EngineState { get; set; } = false;

        public Thread? EngineRuntime { get; set; }

        public void Start()
        {
            if (EngineState)
                Console.WriteLine("The engine is already on! Can't you hear it?");
            else
            {
                Console.WriteLine("Brum Brum... The engine has started");
                EngineState = true;

                EngineRuntime = new Thread(Running);
                EngineRuntime.Start();
            }
        }

        public void Stop()
        {
            if (EngineState)
            {
                EngineState = false;
                Console.WriteLine("Brum Brum... The engine has started");
            }
            else
            {
                Console.WriteLine("The engine is already on! Can't you hear it?");
            }
        }

        public void Running()
        {
            while (EngineState)
            {
                Console.WriteLine("Brum Brum...");

                Throttle Throttle = new Throttle { };

                int ThrottleState = Throttle.GetThrottleState();

                if (ThrottleState == 0) ThrottleState = Throttle.Idle;

                int TimeBetweenUpdate = ThrottleState * 10;

                Thread.Sleep(TimeBetweenUpdate);
            }
        }
    }
}
