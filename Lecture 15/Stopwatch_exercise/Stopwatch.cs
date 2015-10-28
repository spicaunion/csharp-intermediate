using System;

namespace Stopwatch_exercise
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;

        public bool IsRunning { get; private set; }

        public TimeSpan Duration
        {
            get
            {
                var endTime = IsRunning ? DateTime.Now : _stopTime;
                return endTime - _startTime;
            }
        }

        public void Start()
        {
            if (IsRunning)
                throw new InvalidOperationException("Stopwatch is alreay running!");

            _startTime = DateTime.Now;
            IsRunning = true;
        }

        public void Stop()
        {
            if (IsRunning)
                _stopTime = DateTime.Now;
            IsRunning = false;
        }
    }
}
