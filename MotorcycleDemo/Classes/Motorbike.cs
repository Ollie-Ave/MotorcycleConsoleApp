using MotorcycleDemo.Interfaces;

namespace MotorcycleDemo.Classes
{
    public class Motorbike : IMotorbike
    {
        public IBikeInfo BikeInfo { get; set; } = new BikeInfoGeneric { };

        private bool EngineStatus { get; set; } = false;

        private int EngineTickSpeed { get; set; } = 300;

        private bool Accelerating { get; set; }

        public int CurrentSpeed { get; set; } = 0;

        private Thread? EngineRuntimeThread { get; set; }

        public void StartEngine()
        {
            if (!EngineStatus)
            {
                Console.WriteLine("The engine has been started.. Brum Brum");

                EngineStatus = true;

                EngineRuntimeThread = new Thread(EngineRuntime);
                EngineRuntimeThread.Start();
            }
            else
            {
                Console.WriteLine("The engine is already on!");
            }
        }

        public void StopEngine()
        {
            if (EngineStatus)
            {
                Console.WriteLine("The engine has been stopped");
                EngineStatus = false;
            }
            else
            {
                Console.WriteLine("The engine is already off!");
            }

        }

        public void EngineRuntime()
        {
            while (EngineStatus)
            {
                if (Accelerating)
                {
                    ++CurrentSpeed;
                }
                else if (CurrentSpeed == 0)
                {
                }
                else
                {
                    --CurrentSpeed;
                }
                Console.WriteLine("EngineTick, speed: " + CurrentSpeed.ToString() + "MPH");
                Thread.Sleep(EngineTickSpeed);
            }
        }

        public void Accelerate()
        {
            Accelerating = true;
        }

        public void Decelerate()
        {
            Accelerating = false;
        }
    }
}