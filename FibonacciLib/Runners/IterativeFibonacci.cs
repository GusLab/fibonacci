using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciLib.Runners
{
    public sealed class IterativeFibonacci : FibonacciBase, IFibonacci
    {
        public IterativeFibonacci() : base()
        {
        }

        public void Compute(ulong sequenceRange)
        {
            if(sequenceRange == 0)
            {
                return;
            }
            ulong previousNumber = 0, 
                 nextNumber = 1, 
                 sumOfPreviousAndNext = 0;
            Result.Add(previousNumber);
            Result.Add(nextNumber);

            for (uint i = 2; i < sequenceRange; i++)
            {
                sumOfPreviousAndNext = previousNumber + nextNumber;
                Result.Add(sumOfPreviousAndNext);
                previousNumber = nextNumber;
                nextNumber = sumOfPreviousAndNext;
            }
            
        }
    }
}
