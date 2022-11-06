using MotorcycleDemo.Interfaces;

namespace MotorcycleDemo.Classes
{
    class YamahaMTInfo : IBikeInfo
    {
        public int ManufacturerID { get; set; }

        public string Manufacturer { get; set; } = "Yamaha";

        public string MakeAndModel { get; set; } = "MT - ";

        public int EngineSize { get; set; }

        public float Price { get; set; }

    }
}