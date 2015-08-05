using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLib
{
    public class FibonacciBase
    {
        public FibonacciResult Result { get; set; }

        public FibonacciBase()
        {
            Result = new FibonacciResult();
        }
    }
}
