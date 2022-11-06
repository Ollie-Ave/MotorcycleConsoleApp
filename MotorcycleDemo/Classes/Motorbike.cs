using MotorcycleDemo.Interfaces;

namespace MotorcycleDemo.Classes
{
    public class Motorbike : IMotorbike
    {
        // Contain a Bike info class that is accessable through the IBikeInfo interface.
        // This means that we can have many classes 
        public IBikeInfo BikeInfo { get; set; } = new BikeInfoGeneric { };

        // Responsible for keeping track of whether the engine is running or not
        // (Condition to end the while loop within the thread)
        private bool EngineStatus { get; set; } = false;

        // This Dictates how fast the engineruntime loop is
        // It was made a variable so that extension is possible and rpm could be simulated with a throttle and clutch methods
        private int EngineTickSpeed { get; set; } = 300;

        // Dictates whether the bike is increasing or decreasing in speed (special logic applied if Speed = 0)
        private bool Accelerating { get; set; }

        // Stores the bikes current speed
        public int CurrentSpeed { get; set; } = 0;

        public void StartEngine()
        {
            if (!EngineStatus)
            {
                Console.WriteLine("The engine has been started.. Brum Brum");

                // Sets up the thread conditional

                EngineStatus = true;

                // Spins up a new Engine Runtime (starts the engine function in the bacground)
                Thread? EngineRuntimeThread = new Thread(EngineRuntime);
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

                // Signals to thread loop to stop and clean up the thread
                EngineStatus = false;
            }
            else
            {
                Console.WriteLine("The engine is already off!");
            }

        }

        public void EngineRuntime()
        {
            // Responsible for running the engine within a background task

            // Check if the engine is on
            while (EngineStatus)
            {
                // If the bike is accelerating, increase in speed
                if (Accelerating)
                {
                    ++CurrentSpeed;
                }
                // if the bike is stationary, do nothing
                else if (CurrentSpeed == 0)
                {
                }
                // You Guessed it! if the bike is decelerating, down goes the speed.
                else
                {
                    --CurrentSpeed;
                }
                Console.WriteLine("EngineTick, speed: " + CurrentSpeed.ToString() + "MPH");

                // Wait for the prespecified ammount of time, this is an automatically assigned property
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