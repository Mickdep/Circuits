using DP1Circuits.input;
using DP1Circuits.node;
using DP1Circuits.node.operators;
using DP1Circuits.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.circuit
{
    public class CircuitBuilder
    {
        public CircuitBuilder()
        {
            Console.WriteLine("Created CircuitBuilder");
        }

        public Circuit BuildCircuit(Dictionary<string, string> parsedNodes, Dictionary<string, List<string>> parsedEdges)
        {
            Console.WriteLine("Building circuit");
            Circuit circuit = new Circuit();

            var nodes = CreateNodes(parsedNodes);
            
            circuit.Nodes = SortList(nodes);

            CreateEdges(circuit, parsedEdges);

            return circuit;
        }

        private List<Node> SortList(List<Node> nodes)
        {
            var probes = nodes.Where(t => t is Probe).ToList();
            nodes.RemoveAll(t => t is Probe);
            foreach (var p in probes)
            {
                nodes.Add(p);
            }
            return nodes;
        }

        private List<Node> CreateNodes(Dictionary<string, string> parsedNodes)
        {
            NodeFactory nodeFactory = new NodeFactory();
            List<Node> nodes = new List<Node>();

            foreach (var nodePair in parsedNodes)
            {
                Node node = null;
                if (nodePair.Value.Contains(StringUtils.InputNodeIdentifier))
                {
                    node = nodeFactory.CreateNode(StringUtils.InputNodeClassName);
                    node.Name = nodePair.Key;
                    InputNode castInputNode = node as InputNode;
                    if (nodePair.Value.Contains(StringUtils.InputHighIdentifier))
                    {
                        castInputNode.State = new HighInputState();
                    }
                    else
                    {
                        castInputNode.State = new LowInputState();
                    }
                    castInputNode.Request();
                }
                else if (nodePair.Value.Contains(StringUtils.ProbeIdentifier))
                {
                    node = nodeFactory.CreateNode(StringUtils.ProbeClassName);
                    node.Name = nodePair.Key;
                }
                else
                {
                    node = nodeFactory.CreateNode(nodePair.Value);
                    if (node != null)
                    {
                        node.Name = nodePair.Key;
                    }
                }

                nodes.Add(node);
            }
            return nodes;
        }

        private void CreateEdges(Circuit circuit, Dictionary<string, List<string>> parsedEdges)
        {
            foreach (var edge in parsedEdges)
            {
                var node = circuit.Nodes.Where(n => n.Name.Equals(edge.Key)).SingleOrDefault();
                foreach (var destinationNode in edge.Value)
                {
                    var destination = circuit.Nodes.Where(n => n.Name.Equals(destinationNode)).SingleOrDefault();
                    node.DestinationNodes.Add(destination);
                }
            }
        }
    }
}
