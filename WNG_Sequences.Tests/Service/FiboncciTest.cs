using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WNG_Sequences.Core.Model;

namespace WNG_Sequences.Tests.Service
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Fibonacci_Min_Test()
        {
            Fibonacci service = new Fibonacci();
            service.GenerateSequence("1");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase1_Test()
        {
            Fibonacci service = new Fibonacci();
            service.GenerateSequence("A123");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase2_Test()
        {
            Fibonacci service = new Fibonacci();
            service.GenerateSequence("A1 23");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase3_Test()
        {
            Fibonacci service = new Fibonacci();
            service.GenerateSequence("12  3");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase4_Test()
        {
            Fibonacci service = new Fibonacci();
            service.GenerateSequence("12.3");
        }

        [TestMethod]
        public void Fibonacci_Case_10_Test()
        {
            Fibonacci service = new Fibonacci();
            service.GenerateSequence("10");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1, 1, 2, 3, 5, 8");
        }

        [TestMethod]
        public void Fibonacci_Case_17_Test()
        {
            Fibonacci service = new Fibonacci();
            service.GenerateSequence("17");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1, 1, 2, 3, 5, 8, 13");
        }

        [TestMethod]
        public void Fibonacci_Case_120_Test()
        {
            Fibonacci service = new Fibonacci();
            service.GenerateSequence("120");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89");
        }
    }
}
