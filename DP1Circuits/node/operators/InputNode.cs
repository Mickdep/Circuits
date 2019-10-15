using DP1Circuits.input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.node.operators
{
    public class InputNode : Node
    {
        private InputStateBase state;

        public InputNode()
        {

        }

        public override int CalculateOutput()
        {
            //Add base for clarity
            return base.Output;
        }

        public InputStateBase State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
