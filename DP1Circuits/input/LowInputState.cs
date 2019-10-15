using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP1Circuits.node.operators;

namespace DP1Circuits.input
{
    public class LowInputState : InputStateBase
    {
        public override void Handle(InputNode node)
        {
            node.State = this;
            node.Output = 0;
        }
    }
}
