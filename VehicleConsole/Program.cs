using MotorcycleConsoleApp.Classes;
using System;
using System.Collections.Generic;
using VehicleConsole.Classes;

namespace MotorcycleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle
            {
                SysInfo = new Info
                {
                    ManufacturerID = 123123,
                    MakeAndModel = "Mt - 125",
                    Price = 222
                },
                Throttle = new Throttle { },
                Ignition = new Ignition { },
            };

            motorcycle.Ignition.TurnOnIgnition();
            motorcycle.Ignition.StartEngine();

            Thread.Sleep(1000);

            motorcycle.Throttle.AdjustThrottle(100);
        }
    }
}