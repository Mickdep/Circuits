using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits.util
{
    public class StringUtils
    {
        public static string InputNodeIdentifier = "INPUT";
        public static string ProbeIdentifier = "PROBE";

        public static string InputHighIdentifier = "HIGH";

        public static string InputNodeClassName = "InputNode";
        public static string ProbeClassName = "Probe";

        public static readonly string InfiniteLoopExceptionMessage = "Could not simulate circuit because it contains an infinite loop";
        public static readonly string NotConnectedExceptionMessage = "Could not simulate circuit because some of the nodes are not connected";

    }
}
