using DP1Circuits.node.operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.node
{
    public class NodeFactory
    {
        private static readonly string NODE_NAMESPACE = "DP1Circuits.node.operators.";

        public Node CreateNode(string nodeType)
        {
            var type = Type.GetType(NODE_NAMESPACE + nodeType);
            Node node = null;
            if (type != null)
            {
                node = (Node)Activator.CreateInstance(type);
            }
            return node;
        }
    }
}