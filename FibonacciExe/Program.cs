using FibonacciLib;
using FibonacciLib.Runners;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FibonacciExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fibonacci Generator, please enter a range 0 - 5,000");
            Console.WriteLine("to calculate Fibonacci sequence");
            Console.WriteLine();

            ulong range = ReadAndValidateInput();
            List<IFibonacci> implementationList = InitializeRunners();
            Stopwatch stopWatch = new Stopwatch();

            foreach (IFibonacci runner in implementationList)
            {
                Console.WriteLine("Running " + runner.GetType());
                stopWatch.Start();
                runner.Compute(range);
                stopWatch.Stop();
                Console.WriteLine("The result for " + runner.GetType() + " is");
                Console.WriteLine(runner.GetResult());
                Console.WriteLine("and it took " + stopWatch.ElapsedMilliseconds + "ms");
            }

            Console.WriteLine();            
        }

        static ulong ReadAndValidateInput()
        {
            var input = Console.ReadLine();
            ulong output = 0;

            ulong.TryParse(input,out output);

            if((output == 0) | (output > 5000))
            {
                return 0;
            }            

            return output;
        }

        static List<IFibonacci> InitializeRunners()
        {
            List<IFibonacci> implementationList = new List<IFibonacci>();
            implementationList.Add(new IterativeFibonacci());
            implementationList.Add(new RecursiveFibonacci());
            implementationList.Add(new GeneratorFibonacci());

            return implementationList;
        }

    }
}
