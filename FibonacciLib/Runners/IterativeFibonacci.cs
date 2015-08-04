using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciLib.Runners
{
    public sealed class IterativeFibonacci : FibonacciBase, IFibonacci
    {
        public void Compute(long sequenceRange)
        {
            long previousNumber = 0, 
                 nextNumber = 1, 
                 sumOfPreviousAndNext = 0;
            AddToResult(previousNumber);
            AddToResult(nextNumber);

            for (int i = 2; i < sequenceRange; i++)
            {
                sumOfPreviousAndNext = previousNumber + nextNumber;
                AddToResult(sumOfPreviousAndNext);
                previousNumber = nextNumber;
                nextNumber = sumOfPreviousAndNext;
            }
            
        }
    }
}
