using MotorcycleDemo.Interfaces;

namespace MotorcycleDemo.Classes
{
    internal class BikeInfoGeneric : IBikeInfo
    {
        // All just dummy data
        public int ManufacturerID { get; set; }

        public string Manufacturer { get; set; } = "NotSet"; // Setting Default prevents non-nullable warning

        public string MakeAndModel { get; set; } = "NotSet";

        public float Price { get; set; }

        public int EngineSize { get; set; }
    }
}