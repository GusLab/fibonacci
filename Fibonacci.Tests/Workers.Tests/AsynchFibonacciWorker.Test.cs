using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciLib.Runners;
using System.Threading;
using FibonacciLib.Workers;

namespace Fibonacci.Tests.Workers.Tests
{
    [TestClass]
    public class AsynchFibonacciWorkerTest
    {
        [TestMethod]
        public void AsynchWorkerCallbackShouldReturnZeroIfZeroRange()
        {
            var expectedOutput = 0ul;
            var asynchImpl = new AsynchFibonacciWorker(0);

            asynchImpl.AsynchWorkerCallback();

            Assert.AreEqual(expectedOutput, asynchImpl.CalculatedFibonacciNumber);
        }

        [TestMethod]
        public void AsynchWorkerCallbackShouldReturn21If9Range()
        {
            var expectedOutput = 21ul;
            var asynchImpl = new AsynchFibonacciWorker(9);

            asynchImpl.AsynchWorkerCallback();

            Assert.AreEqual(expectedOutput, asynchImpl.CalculatedFibonacciNumber);
        }

        [TestMethod]
        public void AsynchWorkerCallbackShouldReturn9720516145911357709If5000Range()
        {
            var expectedOutput = 9720516145911357709ul;
            var asynchImpl = new AsynchFibonacciWorker(5000);

            asynchImpl.AsynchWorkerCallback();

            Assert.AreEqual(expectedOutput, asynchImpl.CalculatedFibonacciNumber);
        }
    }
}
