using System;
using MotorcycleDemo.Classes;
using MotorcycleDemo.Interfaces;

namespace MotorcycleDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            IMotorbike YamahaMT125 = new YamahaMT
            {
                BikeInfo = new YamahaMTInfo
                {
                    ManufacturerID = 3123,
                    MakeAndModel = "Yamaha MT - 125",
                    Price = (float)2700.0,
                    EngineSize = 125,
                },
            };

            YamahaMT125.StartEngine();
            YamahaMT125.Accelerate();
            
            Thread.Sleep(10000);
            YamahaMT125.StopEngine();
            YamahaMT125.Decelerate();
            Thread.Sleep(10000);
            Console.WriteLine(YamahaMT125.BikeInfo.MakeAndModel);
            YamahaMT125.StopEngine();

        }
    }
}