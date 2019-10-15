using DP1Circuits.circuit;
using DP1Circuits.node;
using DP1Circuits.node.operators;
using DP1Circuits.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DP1Circuits
{
    public class Mediator
    {
        public Circuit Circuit { get; set; }

        private Mediator(){ }

        public void SimulateCircuit()
        {
            Console.WriteLine("Simulating circuit");
            foreach (var node in Circuit.Nodes)
            {
                string destinations = " ---> ";
                var output = node.CalculateOutput();
                node.Output = output;
                foreach (var destination in node.DestinationNodes)
                {
                    if (destination is Probe)
                    {
                        destination.Output = output;
                    }
                    else
                    {
                        destination.Input.Add(output);
                    }
                    destinations += destination.Name + " ";
                }
                var printResult = node.Name + destinations;
                Console.WriteLine(printResult + " ---> Output: " + node.Output);
            }
        }

        public void ResetCircuit()
        {
            foreach (var n in Circuit.Nodes)
            {
                if (!(n is InputNode))
                {
                    n.Input.Clear();
                    n.Output = 0;
                }
            }
            Console.Clear();
        }
    }
}
