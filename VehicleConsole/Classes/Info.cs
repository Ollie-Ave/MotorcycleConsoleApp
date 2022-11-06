using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleConsole.Interfaces;

namespace VehicleConsole.Classes
{
    internal class Info : IInfo
    {
        public int ManufacturerID { get; set; }

        public string MakeAndModel { get; set; }

        public int Price { get; set; }
    }
}
