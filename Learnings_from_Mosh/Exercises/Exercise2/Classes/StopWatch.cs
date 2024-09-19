using System;

namespace Classes
{
    internal class StopWatch
    {
        private DateTime _startTime = new DateTime();
        private DateTime _endTime = new DateTime();
        private bool _running;

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("StopWatch Already Running.");
                
            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("StopWatch Already Stopped.");

            _endTime = DateTime.Now;
            _running = false;
            
        }

        public TimeSpan Duration()
        {
            return _endTime - _startTime;
            
        }
    }
}
