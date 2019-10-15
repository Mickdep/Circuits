using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DP1Circuits.circuit;
using DP1Circuits.node;
using DP1Circuits.node.operators;

namespace DP1CircuitTests
{
    /// <summary>
    /// Summary description for NOTTest
    /// </summary>
    [TestClass]
    public class NOTTest
    {
        public List<int> Input;
        [TestMethod]
        public void ZeroAsInputNOT()
        {
            Node and = new NOT();
            Input = new List<int>();
            Input.Add(0);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 1);
        }
        [TestMethod]
        public void OneAsInputNOT()
        {
            Node and = new NOT();
            Input = new List<int>();
            Input.Add(1);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
    }
}
