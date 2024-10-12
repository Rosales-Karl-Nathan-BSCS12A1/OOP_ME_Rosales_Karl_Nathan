
namespace ConsoleApp1.Exam
{
    // Car and Engine (Composition example)
    public class Car
    {
        private readonly Engine _engine;

        public bool IsEngineStarted { get; private set; } = true;

        public Car(Engine engine)
        {
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
        }

        public void StartCar()
        {
            _engine.Start();
            IsEngineStarted = true;
        }

        public void StopCar()
        {
            _engine.Stop();
            IsEngineStarted = false;
        }
    }

    public class Engine
    {
        private bool _isRunning = false;

        public bool IsRunning
        {
            get { return _isRunning; }
        }

        public void Start()
        {
            _isRunning = true;
        }

        public void Stop()
        {
            _isRunning = false;
        }
    }
}






