using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciLib.Enumerators;
using System.Linq;
using System.Text;

namespace Fibonacci.Tests.Enumerators.Tests
{
    [TestClass]
    public class FibonacciEnumeratorTest
    {
        [TestMethod]
        public void FibonacciEnumeratorTakeWhileLess10()
        {
            var expectedResult = "0 1 1 2 3 5 8";
            StringBuilder actualResultBuilder = new StringBuilder();
            foreach (ulong fibonacciNumber in FibonacciEnumerator.Sequence()
            .TakeWhile(number => number <= 10))
            {
                actualResultBuilder.Append(fibonacciNumber);
                actualResultBuilder.Append(" ");                                              
            }
            Assert.AreEqual(expectedResult, actualResultBuilder.ToString().Trim());
        }

        [TestMethod]
        public void FibonacciEnumeratorTakeWhileIs0()
        {
            var expectedResult = "0";
            StringBuilder actualResultBuilder = new StringBuilder();
            foreach (ulong fibonacciNumber in FibonacciEnumerator.Sequence()
            .TakeWhile(number => number <= 0))
            {
                actualResultBuilder.Append(fibonacciNumber);
                actualResultBuilder.Append(" ");
            }
            Assert.AreEqual(expectedResult, actualResultBuilder.ToString().Trim());
        }
    }
}
