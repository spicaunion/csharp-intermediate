using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stopwatch_exercise;
using System;
using System.Threading;

namespace Stopwatch_tests
{
    [TestClass]
    public class StopwatchTests
    {
        [TestMethod]
        public void Stopwatch_IsIintiallyNotRunning()
        {
            var sw = new Stopwatch();
            Assert.IsFalse(sw.IsRunning);
        }

        [TestMethod]
        public void Duration_IsInitiallyZero()
        {
            var sw = new Stopwatch();
            Assert.AreEqual(0, sw.Duration.TotalMilliseconds);
        }

        [TestMethod]
        public void Start_SetsIsRunningToTrue()
        {
            var sw = new Stopwatch();
            sw.Start();
            Assert.IsTrue(sw.IsRunning);
        }

        [TestMethod]
        public void Stop_SetsIsRunningToFalse()
        {
            var sw = new Stopwatch();
            sw.Start();
            sw.Stop();
            Assert.IsFalse(sw.IsRunning);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Start_WhileAlreadyRunning_ThrowsException()
        {
            var sw = new Stopwatch();
            sw.Start();
            sw.Start();
        }

        [TestMethod]
        public void Stop_WhenNotRunning_DoesNotChangeDuration()
        {
            var sw = new Stopwatch();
            sw.Start();
            Thread.Sleep(100);
            sw.Stop();
            var duration = sw.Duration;
            sw.Stop();
            Assert.AreEqual(duration, sw.Duration);
        }

        [TestMethod]
        public void Duration_WhileRunning_IsCorrect()
        {
            var sw = new Stopwatch();
            var waitDuration = GetRandomDuration(100, 1000);
            sw.Start();
            Thread.Sleep((int)waitDuration.TotalMilliseconds);
            Assert.AreEqual((int)waitDuration.TotalSeconds, (int)sw.Duration.TotalSeconds);
        }

        [TestMethod]
        public void Duration_WhenStopped_IsCorrect()
        {
            var sw = new Stopwatch();
            var waitDuration = GetRandomDuration(100, 1000);
            sw.Start();
            Thread.Sleep((int)waitDuration.TotalMilliseconds);
            sw.Stop();
            Assert.AreEqual((int)waitDuration.TotalSeconds, (int)sw.Duration.TotalSeconds);
        }

        [TestMethod]
        public void MultipleStartStops_DurationIsStillCorrect()
        {
            var sw = new Stopwatch();
            for (int i = 0; i < new Random().Next(2, 10); i++)
            {
                sw.Start();
                Thread.Sleep((int)GetRandomDuration(1, 10).TotalMilliseconds);
                sw.Stop();
            }
            var waitDuration = GetRandomDuration(100, 1000);
            sw.Start();
            Thread.Sleep((int)waitDuration.TotalMilliseconds);
            sw.Stop();
            Assert.AreEqual((int)waitDuration.TotalSeconds, (int)sw.Duration.TotalSeconds);
        }

        private TimeSpan GetRandomDuration(int min, int max)
        {
            return TimeSpan.FromMilliseconds(new Random().Next(min, max));
        }
    }
}
