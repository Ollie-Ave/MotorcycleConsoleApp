namespace MotorcycleDemo.Interfaces
{
    public interface IBikeInfo
    {
        int ManufacturerID { get; set; }

        string MakeAndModel { get; set; }

        string Manufacturer { get; set; }

        float Price { get; set; }

        int EngineSize { get; set; }
    }

}