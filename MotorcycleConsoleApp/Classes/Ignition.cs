using MotorcycleConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConsoleApp.Classes
{
    internal class Ignition: Engine
    {
        public int SerialNumber { get; set; }

        public string PartName { get; set; }

        public string PartManufacturer { get; set; }

        public bool IgnitionState { get; set; } = false;

        public void TurnOnIgnition()
        {
            if (IgnitionState)
                Console.WriteLine("The ignition is already primed and ready to go!");
            else
            {
                IgnitionState = true;
                Console.WriteLine("The ignition is primed");
            }
        }

        public void TurnOffIgnition()
        {
            if (IgnitionState)
            {
                IgnitionState = false;
                Console.WriteLine("The ignition has been turned off.");
            }
            else
                Console.WriteLine("The ignition is already off");
        }

        public void StartEngine(IEngine Engine)
        {
            base.Engine.Start();
        }

        public void StopEngine(IEngine Engine)
        {
            base.Engine.Stop();
        }
    }
}
