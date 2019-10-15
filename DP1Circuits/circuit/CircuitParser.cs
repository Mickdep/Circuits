using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.circuit
{
    public class CircuitParser
    {
        private List<string> FileInput { get; set; }

        public CircuitParser(List<string> fileInput)
        {
            FileInput = fileInput;
            SanitizeInput();
            Console.WriteLine("Created Parser");
        }

        //Remove comment lines
        public void SanitizeInput()
        {
            FileInput.RemoveAll(s => s.StartsWith("#"));
        }

        //Dictionary <node_identifier, node_decriptor>
        public Dictionary<string, string> ParseNodes()
        {
            Dictionary<string, string> parsedNodes = new Dictionary<string, string>();
            var splitIndex = FileInput.FindIndex(s => string.IsNullOrEmpty(s));
            var nodes = FileInput.GetRange(0, splitIndex);

            foreach (var node in nodes)
            {
                string[] splitNode = node.Split(':');
                var nodeIdentifier = splitNode[0];
                var nodeDescriptor = splitNode[1].Trim().Replace(";", string.Empty);
                parsedNodes.Add(nodeIdentifier, nodeDescriptor);
            }

            return parsedNodes;
        }
        //Dictionary <node_source_identifier, node_target_identifiers>
        public Dictionary<string, List<string>> ParseEdges()
        {
            Dictionary<string, List<string>> parsedEdges = new Dictionary<string, List<string>>();
            var splitIndex = FileInput.FindIndex(s => string.IsNullOrEmpty(s)) + 1;
            var edges = FileInput.GetRange(splitIndex, FileInput.Count - splitIndex);

            foreach (var edge in edges)
            {
                string[] splitEdge = edge.Split(':');
                var nodeSourceIdentifier = splitEdge[0];
                var nodeTargetIdentifiers = splitEdge[1].Trim().Replace(";", string.Empty).Split(',').ToList();
                parsedEdges.Add(nodeSourceIdentifier, nodeTargetIdentifiers);
            }
            return parsedEdges;
        }
    }
}
