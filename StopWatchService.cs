using System;
using System.Diagnostics;

namespace StopWatch
{
    public class StopwatchService
    {
        private Stopwatch stopwatch;

        public StopwatchService()
        {
            stopwatch = new Stopwatch();
        }

        public void Start()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }

        public void Reset()
        {
            stopwatch.Reset();
        }

        public TimeSpan Elapsed => stopwatch.Elapsed;
    }
}
