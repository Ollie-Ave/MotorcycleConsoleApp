using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConsoleApp.Interfaces
{
    internal interface IGearBox
    {
        public int CurrentGear { get; set; }

        public int MaxGear { get; set; }

        public List<float> GearRatios { get; set; }

        public float CurrentGearRatio { get; set; }
    }
}
