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
    /// Summary description for NORTest
    /// </summary>
    [TestClass]
    public class NORTest
    {
        public List<int> Input;
        [TestMethod]
        public void ZeroAsInputNOR()
        {
            Node and = new NOR();
            Input = new List<int>();
            Input.Add(0);
            Input.Add(0);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 1);
        }
        [TestMethod]
        public void ZeroAndOneAsInputNOR()
        {
            Node and = new NOR();
            Input = new List<int>();
            Input.Add(0);
            Input.Add(1);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
        [TestMethod]
        public void OneAndZeroAsInputNOR()
        {
            Node and = new NOR();
            Input = new List<int>();
            Input.Add(1);
            Input.Add(0);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
        [TestMethod]
        public void OneAsInputNOR()
        {
            Node and = new NOR();
            Input = new List<int>();
            Input.Add(1);
            Input.Add(1);
            and.Input = Input;
            var output = and.CalculateOutput();
            Assert.AreEqual(output, 0);
        }
    }
}
