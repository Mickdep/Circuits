using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DP1Circuits.circuit;
using DP1Circuits.node;
using DP1Circuits.node.operators;
using System.Collections.Generic;

namespace DP1CircuitTests
{
    [TestClass]
    public class ANDTest
    {
        public List<int> Input;
        [TestMethod]
        public void ZeroAsInputAND()
        {
            Node and = new AND();
            Input = new List<int>();
            Input.Add(0);
            Input.Add(0);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
        [TestMethod]
        public void ZeroAndOneAsInputAND()
        {
            Node and = new AND();
            Input = new List<int>();
            Input.Add(0);
            Input.Add(1);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
        [TestMethod]
        public void OneAndZeroAsInputAND()
        {
            Node and = new AND();
            Input = new List<int>();
            Input.Add(1);
            Input.Add(0);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
        [TestMethod]
        public void OneAsInputAND()
        {
            Node and = new AND();
            Input = new List<int>();
            Input.Add(1);
            Input.Add(1);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 1);
        }
    }
}
