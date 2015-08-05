using FibonacciLib.Workers;
using System.Threading.Tasks;

namespace FibonacciLib.Runners
{
    public class AsynchFibonacci : FibonacciBase, IFibonacci
    {
        Task[] AsynchCompletedTasks { get; set; }
        AsynchFibonacciWorker[] AsynchFibonacciWorkers { get; set; }

        public AsynchFibonacci() : base()
        {            
        }

        public void Compute(ulong sequenceRange)
        {
            this.InitializeWorkerPool(sequenceRange);
            this.StartWorkers(sequenceRange);

            Task.WaitAll(AsynchCompletedTasks);

            foreach (var worker in AsynchFibonacciWorkers)
            {
                Result.Add(worker.CalculatedFibonacciNumber);
            }
        }

        void InitializeWorkerPool(ulong sequenceRange)
        {
            AsynchFibonacciWorkers = new AsynchFibonacciWorker[sequenceRange];
            AsynchCompletedTasks = new Task[sequenceRange];

            for (ulong i = 0ul; i < sequenceRange; i++)
            {
                AsynchFibonacciWorker worker = new AsynchFibonacciWorker(i+1);
                AsynchFibonacciWorkers[i] = worker;
            }
        }

        void StartWorkers(ulong sequenceRange)
        {
            int i = 0;
            foreach (var worker in AsynchFibonacciWorkers)
            {
                AsynchCompletedTasks[i] = Task.Factory.StartNew(() => worker.AsynchWorkerCallback());
                i++;
            }
        }
    }
}
