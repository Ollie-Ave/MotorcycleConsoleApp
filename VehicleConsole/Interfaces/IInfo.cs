using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleConsole.Interfaces
{
    internal interface IInfo
    {
        int ManufacturerID { get; set; }

        string MakeAndModel { get; set; }

        int Price { get; set; }
    }
}
