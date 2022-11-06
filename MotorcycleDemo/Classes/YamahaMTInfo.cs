using MotorcycleDemo.Interfaces;

namespace MotorcycleDemo.Classes
{
    class YamahaMTInfo : IBikeInfo
    {
        // Again, All just dummy data but in production we would have useful data here
        public int ManufacturerID { get; set; }

        public string Manufacturer { get; set; } = "Yamaha";

        public string MakeAndModel { get; set; } = "MT - ";

        public int EngineSize { get; set; }

        public float Price { get; set; }

    }
}