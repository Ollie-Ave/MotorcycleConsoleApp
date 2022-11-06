using MotorcycleConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConsoleApp.Classes
{
    internal class Engine : Motorcycle, IEngine
    {
        public int SerialNumber { get; set; }

        public string PartName { get; set; }

        public string PartManufacturer { get; set; }

        public bool EngineState { get; set; } = false;
        
        public int ThrottleState { get; set; }

        public float Speed { get; set; }

        public int RPM { get; set; }

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

                if (ThrottleState > 0)
                {
                    Speed = RPM * GearBox.CurrentGearRatio;
                }

                Thread.Sleep(RPM);
            }
        }
    }
}
