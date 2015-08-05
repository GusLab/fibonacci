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

        public void Compute(long sequenceRange)
        {
            RecurseToNextNumber(0, 1, 1, sequenceRange);
        }

        void RecurseToNextNumber(long previousNumber,
                                 long nextNumber,
                                 long recurseIterator,
                                 long sequenceRange)
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
