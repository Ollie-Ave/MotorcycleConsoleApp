using MotorcycleConsoleApp.Classes;

namespace MotorcycleConsoleApp.Interfaces
{
    public interface IEngine 
    {
        int SerialNumber { get; set; }

        string PartName { get; set; }

        string PartManufacturer { get; set; }

        bool EngineState { get; set; }

        int ThrottleState { get; set; }

        float Speed { get; set; }

        int RPM { get; set; }

        Thread? EngineRuntime { get; set; }

        void Start();
        void Stop();
        void Running();
    }
}