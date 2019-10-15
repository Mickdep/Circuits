using DP1Circuits.node.operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.input
{
    public abstract class InputStateBase
    {
        public abstract void Handle(InputNode node);
    }
}
