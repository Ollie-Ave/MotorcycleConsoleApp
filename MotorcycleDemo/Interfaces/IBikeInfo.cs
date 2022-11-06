namespace MotorcycleDemo.Interfaces
{
    public interface IBikeInfo
    {
        // Scaffolds out the interface in which we can interact with IBikeInfo
        // All child classes of this must contain definitions for the following properties (and methods if we chose to include them)
        // They may contain extensions of this dataset here but cannot be accessed when utilising this interface,
        // However, a class can be a child of multiple Interfaces which may implement the extended data and methods.
        int ManufacturerID { get; set; }

        string MakeAndModel { get; set; }

        string Manufacturer { get; set; }

        float Price { get; set; }

        int EngineSize { get; set; }
    }

}