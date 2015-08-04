using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciLib.Runners;
using System.Text;
using System;
using System.IO;

namespace Fibonacci.Tests.Runners.Tests
{
    [TestClass]
    public class RecursiveFibonacciTest
    {
        [TestMethod]
        public void RecursiveShouldReturn9FirstElements()
        {
            var expectedConsoleOutput = "0 1 1 2 3 5 8 13 21";
            var actualConsoleOutput = "";
            var recursiveImpl = new RecursiveFibonacci();

            recursiveImpl.Compute(9);
            actualConsoleOutput = recursiveImpl.Result.ToString();

            Assert.AreEqual(expectedConsoleOutput, actualConsoleOutput, false);
        }
    }
}
