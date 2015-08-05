using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciLib.Runners
{
    public sealed class RecursiveFibonacci : FibonacciBase, IFibonacci
    {
        public RecursiveFibonacci() : base()
        {
        }

        public void Compute(ulong sequenceRange)
        {
            RecurseToNextNumber(0, 1, 1, sequenceRange);
        }

        void RecurseToNextNumber(ulong previousNumber,
                                 ulong nextNumber,
                                 ulong recurseIterator,
                                 ulong sequenceRange)
        {
            if (recurseIterator <= sequenceRange)
            {
                Result.Add(previousNumber);
                RecurseToNextNumber(nextNumber,
                                    previousNumber + nextNumber,
                                    recurseIterator + 1,
                                    sequenceRange);
            }
        }

    }
}
