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
    /// Summary description for XORTest
    /// </summary>
    [TestClass]
    public class XORTest
    {
        public List<int> Input;
        [TestMethod]
        public void ZeroAsInputXOR()
        {
            Node and = new XOR();
            Input = new List<int>();
            Input.Add(0);
            Input.Add(0);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
        [TestMethod]
        public void ZeroAndOneAsInputXOR()
        {
            Node and = new XOR();
            Input = new List<int>();
            Input.Add(0);
            Input.Add(1);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 1);
        }
        [TestMethod]
        public void OneAndZeroAsInputXOR()
        {
            Node and = new XOR();
            Input = new List<int>();
            Input.Add(1);
            Input.Add(0);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 1);
        }
        [TestMethod]
        public void OneAsInputXOR()
        {
            Node and = new XOR();
            Input = new List<int>();
            Input.Add(1);
            Input.Add(1);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
    }
}
