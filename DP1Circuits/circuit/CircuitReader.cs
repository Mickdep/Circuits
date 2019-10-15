using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.circuit
{
    public class CircuitReader
    {
        public CircuitReader()
        {
            Console.WriteLine("Created CircuitReader");
        }

        public List<string> ReadFile(string path)
        {
            Console.WriteLine("Reading file");
            List<string> fileInput = File.ReadLines(path).ToList();
            return fileInput;
        }
    }
}
