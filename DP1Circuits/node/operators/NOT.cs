using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.node.operators
{
    public class NOT : Node
    {
        public override int CalculateOutput()
        {
            int result = 1;
            if (Input.ElementAt(0) == 1) {
                result = 0;
            }
            return result;
        }
    }
}
