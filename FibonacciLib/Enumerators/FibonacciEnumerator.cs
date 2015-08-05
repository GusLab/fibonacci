using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLib.Enumerators
{
    class FibonacciEnumerator
    {
        public static IEnumerable<ulong> Sequence()
        {
            ulong previousNumber = 0;
            ulong nextNumber = 1;

            yield return previousNumber;
            yield return nextNumber;

            while (true)
            {
                ulong sumOfPreviousAndNext = previousNumber + nextNumber;
                yield return sumOfPreviousAndNext;

                previousNumber = nextNumber;
                nextNumber = sumOfPreviousAndNext;
            }
        }
    }
}
