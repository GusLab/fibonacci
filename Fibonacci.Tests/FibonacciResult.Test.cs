using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciLib;

namespace Fibonacci.Tests
{
    [TestClass]
    public class FibonacciResultTest
    {
        [TestMethod]
        public void FibonacciResultAddMethodAdds10ConsecutiveNumbers()
        {
            var expectedResult = "0 1 2 3 4 5 6 7 8 9";
            var fibonacciResult = new FibonacciResult();

            for (int i = 0; i < 10; i++)
            {
                fibonacciResult.Add(i);
            }

            Assert.AreEqual(expectedResult, fibonacciResult.Get, false);
        }
    }
}
