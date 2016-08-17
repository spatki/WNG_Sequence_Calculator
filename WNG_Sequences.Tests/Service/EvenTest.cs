using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WNG_Sequences.Core.Model;

namespace WNG_Sequences.Tests.Service
{
    [TestClass]
    public class EvenTest
    {
        [TestMethod]
        public void Even_Min_Test()
        {
            Even service = new Even();
            service.GenerateSequence("1");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase1_Test()
        {
            Even service = new Even();
            service.GenerateSequence("A123");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase2_Test()
        {
            Even service = new Even();
            service.GenerateSequence("A1 23");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase3_Test()
        {
            Even service = new Even();
            service.GenerateSequence("12  3");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase4_Test()
        {
            Even service = new Even();
            service.GenerateSequence("12.3");
        }

        [TestMethod]
        public void Even_Case_10_Test()
        {
            Even service = new Even();
            service.GenerateSequence("10");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "2, 4, 6, 8, 10");
        }

        [TestMethod]
        public void Even_Case_17_Test()
        {
            Even service = new Even();
            service.GenerateSequence("17");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "2, 4, 6, 8, 10, 12, 14, 16");
        }

        [TestMethod]
        public void Even_Case_120_Test()
        {
            Even service = new Even();
            service.GenerateSequence("120");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "2, 4, 6, 8, 10, 12, 14, 16, 18, 20, " +
                                    "22, 24, 26, 28, 30, 32, 34, 36, 38, 40, " +
                                    "42, 44, 46, 48, 50, 52, 54, 56, 58, 60, " +
                                    "62, 64, 66, 68, 70, 72, 74, 76, 78, 80, " +
                                    "82, 84, 86, 88, 90, 92, 94, 96, 98, 100, " +
                                    "102, 104, 106, 108, 110, 112, 114, 116, 118, 120");
        }
    }
}
