using MotorcycleConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleConsole.Interfaces;

namespace VehicleConsole.Classes
{
    internal class Motorcycle 
    {
        public IInfo SysInfo { get; set; }

        public Ignition Ignition { get; set; } 

        public Throttle Throttle { get; set; } 

    }
}
