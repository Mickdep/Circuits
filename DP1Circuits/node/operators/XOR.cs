using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.node.operators
{
    public class XOR : Node
    {
        public override int CalculateOutput()
        {
            int result = 0;
            int inputA = Input.ElementAt(0);
            int inputB = Input.ElementAt(1);

            if((inputA == 1 && inputB == 0) || (inputB == 1 && inputA == 0))
            {
                result = 1;
            }

            return result;
        }
    }
}
