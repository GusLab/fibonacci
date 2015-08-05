using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLib
{
    public sealed class FibonacciResult
    {
        string _result;
        public string Get { get { return _result; } }
        public void Add(long nextFibonacciNumber)
        {
            _result = _result + " " + nextFibonacciNumber;
            _result = _result.Trim();
        }
    }
}
