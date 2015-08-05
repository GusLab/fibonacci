using FibonacciLib.Enumerators;
using System;
using System.Linq;

namespace FibonacciLib.Runners
{
    public sealed class GeneratorFibonacci : FibonacciBase, IFibonacci
    {
        public GeneratorFibonacci() : base()
        {
        }

        public void Compute(ulong sequenceRange)
        {
            foreach (ulong fibonacciNumber in FibonacciEnumerator.Sequence()
            .Take((int)sequenceRange))
            {
                Result.Add(fibonacciNumber);
            }
        }
    }
}
