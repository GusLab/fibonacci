using FibonacciLib.Enumerators;
using System.Linq;
using System.Threading;


namespace FibonacciLib.Workers
{
    public class AsynchFibonacciWorker
    {
        public ulong SequenceRange { get; private set; }
        public ulong CalculatedFibonacciNumber { get; private set; }

        AsynchFibonacciWorker()
        {

        }

        public AsynchFibonacciWorker(ulong sequenceRange)
        {
            SequenceRange = sequenceRange;
            if (SequenceRange == 0) SequenceRange = 1;
        }

        public void AsynchWorkerCallback()
        {
            CalculatedFibonacciNumber = FibonacciEnumerator.Sequence()
                                            .ElementAt((int)(SequenceRange-1));
        }
    }
}
