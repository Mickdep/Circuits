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
    /// Summary description for NANDTest
    /// </summary>
    [TestClass]
    public class NANDTest
    {
        public List<int> Input;
        [TestMethod]
        public void ZeroAsInputNAND()
        {
            Node and = new NAND();
            Input = new List<int>();
            Input.Add(0);
            Input.Add(0);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 1);
        }
        [TestMethod]
        public void ZeroAndOneAsInputNAND()
        {
            Node and = new NAND();
            Input = new List<int>();
            Input.Add(0);
            Input.Add(1);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 1);
        }
        [TestMethod]
        public void OneAndZeroAsInputNAND()
        {
            Node and = new NAND();
            Input = new List<int>();
            Input.Add(1);
            Input.Add(0);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 1);
        }
        [TestMethod]
        public void OneAsInputNAND()
        {
            Node and = new NAND();
            Input = new List<int>();
            Input.Add(1);
            Input.Add(1);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
    }
}
