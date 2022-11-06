namespace MotorcycleDemo.Interfaces
{
    public interface IMotorbike
    {
        // Scaffolds out the interface in which we can interact with IBike
        // Largely the same as the IBikeInfo file in terms of comments here
        // Only other thing to add is that these properties and methods do not have
        // implementations and therfore an interface needs implementation of these features via the use of a class

        IBikeInfo BikeInfo { get; set; }

        int CurrentSpeed { get; set; }

        void StartEngine();
        void StopEngine();
        void EngineRuntime();
        void Accelerate();
        public void Decelerate();
    }
}