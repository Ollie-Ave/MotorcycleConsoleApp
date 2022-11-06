using MotorcycleDemo.Interfaces;

namespace MotorcycleDemo.Classes
{
    class HondaCBRInfo : IBikeInfo
    {
        // Again, All just dummy data but in production we would have useful data here
        public int ManufacturerID { get; set; }

        public string Manufacturer { get; set; } = string.Empty;

        public string MakeAndModel { get; set; } = string.Empty;

        public float Price { get; set; }

        public int EngineSize { get; set; }
    }
}