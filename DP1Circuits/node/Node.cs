using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.node
{
    public abstract class Node
    {
        public int Output;

        public string Name;

        //Possible multiple inputs
        public List<int> Input = new List<int>();

        public List<Node> DestinationNodes = new List<Node>();

        public abstract int CalculateOutput();
    }
}
