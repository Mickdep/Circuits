using DP1Circuits.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.circuit.exception
{
    public class InfiniteLoopException : Exception
    {
        public InfiniteLoopException()
        {
            Console.WriteLine("==== ERROR ====");
            Console.WriteLine(StringUtils.InfiniteLoopExceptionMessage);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public InfiniteLoopException(string message)
        : base(message)
        {

        }

        public InfiniteLoopException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
