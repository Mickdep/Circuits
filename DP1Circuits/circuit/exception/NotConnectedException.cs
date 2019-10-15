using DP1Circuits.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.circuit.exception
{
    public class NotConnectedException : Exception
    {
        public NotConnectedException()
        {
            Console.WriteLine("==== ERROR ====");
            Console.WriteLine(StringUtils.NotConnectedExceptionMessage);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public NotConnectedException(string message)
        : base(message)
        {

        }

        public NotConnectedException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
