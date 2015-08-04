using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciLib.Runners;
using System.Text;
using System;
using System.IO;

namespace Fibonacci.Tests.Runners.Tests
{
    [TestClass]
    public class IterativeFibonacciTest
    {
        [TestMethod]
        public void IterativeShouldReturn9FirstElements()
        {
            var expectedConsoleOutput = "0 1 1 2 3 5 8 13 21";
            var actualConsoleOutput = "";
            var iterativeImpl = new IterativeFibonacci();

            iterativeImpl.Compute(9);
            actualConsoleOutput = iterativeImpl.Result.ToString();

            Assert.AreEqual(expectedConsoleOutput,actualConsoleOutput,false);
        }
    }
}
