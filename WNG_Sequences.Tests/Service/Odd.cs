using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WNG_Sequences.Core.Model;

namespace WNG_Sequences.Tests.Service
{
    [TestClass]
    public class OddTest
    {
        [TestMethod]
        public void Odd_Min_Test()
        {
            Odd service = new Odd();
            service.GenerateSequence("1");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase1_Test()
        {
            Odd service = new Odd();
            service.GenerateSequence("A123");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase2_Test()
        {
            Odd service = new Odd();
            service.GenerateSequence("A1 23");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase3_Test()
        {
            Odd service = new Odd();
            service.GenerateSequence("12  3");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase4_Test()
        {
            Odd service = new Odd();
            service.GenerateSequence("12.3");
        }

        [TestMethod]
        public void Odd_Case_10_Test()
        {
            Odd service = new Odd();
            service.GenerateSequence("10");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1, 3, 5, 7, 9");
        }

        [TestMethod]
        public void Odd_Case_17_Test()
        {
            Odd service = new Odd();
            service.GenerateSequence("17");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1, 3, 5, 7, 9, 11, 13, 15, 17");
        }

        [TestMethod]
        public void Odd_Case_120_Test()
        {
            Odd service = new Odd();
            service.GenerateSequence("120");
            var result = service.OutputSequence;
            Assert.AreEqual(result,  "1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99, 101, 103, 105, 107, 109, 111, 113, 115, 117, 119");
        }
    }
}
