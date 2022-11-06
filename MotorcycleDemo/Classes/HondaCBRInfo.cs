using MotorcycleDemo.Interfaces;

namespace MotorcycleDemo.Classes
{
    class HondaCBRInfo : IBikeInfo
    {
        public int ManufacturerID { get; set; }

        public string Manufacturer { get; set; } = string.Empty;

        public string MakeAndModel { get; set; } = string.Empty;

        public float Price { get; set; }

        public int EngineSize { get; set; }
    }
}