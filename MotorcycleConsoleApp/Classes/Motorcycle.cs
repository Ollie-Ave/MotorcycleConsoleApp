using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleConsoleApp.Interfaces;

namespace MotorcycleConsoleApp.Classes
{
    internal class Motorcycle : IMotorcycle
    {
        public int MaunfacturingID { get; set; }

        public string Manufacturer { get; set; }

        public string ModelName { get; set; }

        public string BikeMake { get; set; }

        public IEngine Engine { get; set; }

        public IWheel FrontWheel { get; set; }

        public IWheel RearWheel { get; set; }
  
    }
}
