﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciLib.Runners
{
    public sealed class IterativeFibonacci : FibonacciBase, IFibonacci
    {
        public void Compute(long sequenceRange)
        {
            AddToResult(0);
        }
    }
}
