using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.node.operators
{
    public class AND : Node
    {
        public override int CalculateOutput()
        {
            int inputA = Input.ElementAt(0);
            int inputB = Input.ElementAt(1);

            int result = inputA * inputB;

            return result;
        }
    }
}
