using MotorcycleConsoleApp.Classes;
using MotorcycleConsoleApp.Interfaces;
using System;
using System.Collections.Generic;

namespace MotorcycleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> ratios = new List<float>();

            ratios.Add((float)1.2);
            ratios.Add((float)1.4);
            ratios.Add((float)1.6);
            ratios.Add((float)1.9);
            ratios.Add((float)2.3);
            ratios.Add((float)2.6);


            IMotorcycle motorcycle = new Motorcycle
            {
                MaunfacturingID = 13313,
                Manufacturer = "Yamaha",
                ModelName = "MT",
                BikeMake = "MT - 125",
                Engine = new Engine
                {
                    SerialNumber = 1232,
                    PartName = "MT - 125 Engine-Full",
                    PartManufacturer = "Yamaha",
                    Ignition = new Ignition
                    {
                        SerialNumber = 3123,
                        PartName = "MT - 125 Ignition-Sys",
                        PartManufacturer = "Yamaha",
                    },
                    GearBox = new GearBox
                    {
                        MaxGear = 6,
                        GearRatios = ratios
                    },
                },
                FrontWheel = new Wheel
                {

                },
                RearWheel = new Wheel
                {

                }
            };

            Console.WriteLine(motorcycle.BikeMake);

            motorcycle.Engine.Ignition.TurnOnIgnition();
            motorcycle.Engine.Ignition.StartEngine(motorcycle.Engine);

        }
    }
}