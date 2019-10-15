using DP1Circuits.circuit;
using DP1Circuits.circuit.exception;
using DP1Circuits.node;
using DP1Circuits.node.operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.util
{
    public class CircuitValidator
    {
        private Dictionary<string, int> requiredInputsPerOperator = new Dictionary<string, int>()
        {
            { "NOT", 1 },
            { "AND", 2 },
            { "NAND", 2 },
            { "NOR", 2 },
            { "OR", 2 },
            { "XOR", 2 },
        };

        public void ValidateCircuit(Circuit circuit)
        {
            List<string> occurenceList = new List<string>();

            foreach (var node in circuit.Nodes)
            {
                CheckNotConnected(node, circuit);
                CheckInfiniteLoop(node, occurenceList);
            }
        }

        private void CheckInfiniteLoop(Node node, List<string> occurenceList)
        {
            occurenceList.Add(node.Name);
            var infiniteCheckDestinations = node.DestinationNodes;
            foreach (var d in infiniteCheckDestinations)
            {
                if (occurenceList.Contains(d.Name))
                {
                    throw new InfiniteLoopException();
                }
            }
        }

        private void CheckNotConnected(Node node, Circuit circuit)
        {
            bool inputNode = node is InputNode;

            if (!inputNode)
            {
                int occurenceCounter = 0;
                string nodeType = node.GetType().Name;
                int requiredInputs = requiredInputsPerOperator.Where(s => s.Key.Equals(nodeType)).SingleOrDefault().Value;
                foreach (var node2 in circuit.Nodes)
                {
                    var destinations = node2.DestinationNodes;
                    foreach (var dest in destinations)
                    {
                        if (dest.Name.Equals(node.Name))
                        {
                            occurenceCounter++;
                        }
                    }
                }
                if (occurenceCounter < requiredInputs)
                {
                    throw new NotConnectedException();
                }
            }
        }
    }


}
