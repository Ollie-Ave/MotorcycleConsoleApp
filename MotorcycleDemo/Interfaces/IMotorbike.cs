namespace MotorcycleDemo.Interfaces
{
    public interface IMotorbike
    {
        IBikeInfo BikeInfo { get; set; }

        int CurrentSpeed { get; set; }

        void StartEngine();
        void StopEngine();
        void EngineRuntime();
        void Accelerate();
        public void Decelerate();
    }
}