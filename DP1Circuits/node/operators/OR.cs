using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.node.operators
{
    public class OR : Node
    {
        public override int CalculateOutput()
        {
            int result = 1;
            int inputA = Input.ElementAt(0);
            int inputB = Input.ElementAt(1);

            if(inputA == 0 && inputB == 0)
            {
                result = 0;
            }
            return result;
        }
    }
}
