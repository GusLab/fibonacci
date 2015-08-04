using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLib
{
    public abstract class FibonacciBase
    {
        protected string _result;
        public string Result { get { return _result; } }
        protected void AddToResult(long nextFibonacciNumber)
        {
            _result = _result + " " + nextFibonacciNumber;
            _result = _result.Trim();
        }
    }
}
