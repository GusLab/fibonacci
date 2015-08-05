using System.Collections.Generic;

namespace FibonacciLib.Enumerators
{
    public class FibonacciEnumerator
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
