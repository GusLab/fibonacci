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
            var fakeConsoleBuffer = new StringBuilder();
            var fakeConsole = new StringWriter(fakeConsoleBuffer);
            var expectedConsoleOutput = "0 1 1 2 3 5 8 13 21";
            var actualConsoleOutput = "";
            Console.SetOut(fakeConsole);
            Console.SetError(fakeConsole);
            var recursiveImpl = new RecursiveFibonacci();

            recursiveImpl.Compute(9);
            actualConsoleOutput = fakeConsoleBuffer.ToString();

            StringAssert.Equals(expectedConsoleOutput, actualConsoleOutput);
        }
    }
}
