using MotorcycleDemo.Interfaces;

namespace MotorcycleDemo.Classes
{
    internal class BikeInfoGeneric : IBikeInfo
    {
        public int ManufacturerID { get; set; } = 0;

        public string Manufacturer { get; set; } = "NotSet";

        public string MakeAndModel { get; set; } = "NotSet";

        public float Price { get; set; } = float.MinValue;

        public int EngineSize { get; set; } = 0;
    }
}