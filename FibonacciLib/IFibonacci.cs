using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciLib
{
    public interface IFibonacci
    {
        void Compute(ulong sequenceRange);
        string GetResult();
    }
}
