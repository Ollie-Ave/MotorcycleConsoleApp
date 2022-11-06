using MotorcycleConsoleApp.Classes;

namespace MotorcycleConsoleApp.Interfaces
{
    public interface IIgnition
    {
        public int SerialNumber { get; set; }

        public string PartName { get; set; }

        public string PartManufacturer { get; set; }

        public bool IgnitionState { get; set; }

        void TurnOnIgnition();

        void TurnOffIgnition();

        void StartEngine(IEngine Engine);

        void StopEngine(IEngine Engine);

    }
}