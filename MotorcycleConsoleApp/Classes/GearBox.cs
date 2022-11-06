using MotorcycleConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConsoleApp.Classes
{
    internal class GearBox : IGearBox
    {
        public int CurrentGear { get; set; } = 0;

        public int MaxGear { get; set; }

        public List<float> GearRatios { get; set; }

        public float CurrentGearRatio { get; set; } = 0;
    }
}
