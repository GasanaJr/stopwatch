using System;
using NUnit.Framework;
using StopWatch;

namespace StopwatchTimer.Tests
{
    public class StopwatchServiceTests
    {
        private StopwatchService stopwatchService = null!;

        [SetUp]
        public void Setup()
        {
            stopwatchService = new StopwatchService();
        }

        [Test]
        public void Start_ShouldStartAStopWatch()
        {
            stopwatchService.Start();
            System.Threading.Thread.Sleep(1000);
            stopwatchService.Stop();
            Assert.That(stopwatchService.Elapsed.TotalSeconds, Is.GreaterThanOrEqualTo(1));
        }
    }
}
