using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WNG_Sequences.Core.Model;

namespace WNG_Sequences.Tests.Service
{
    [TestClass]
    public class FizzBizzTest
    {
        [TestMethod]
        public void FizzBizz_Min_Test()
        {
            FizzBizz service = new FizzBizz();
            service.GenerateSequence("1");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase1_Test()
        {
            FizzBizz service = new FizzBizz();
            service.GenerateSequence("A123");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase2_Test()
        {
            FizzBizz service = new FizzBizz();
            service.GenerateSequence("A1 23");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase3_Test()
        {
            FizzBizz service = new FizzBizz();
            service.GenerateSequence("12  3");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase4_Test()
        {
            FizzBizz service = new FizzBizz();
            service.GenerateSequence("12.3");
        }

        [TestMethod]
        public void FizzBizz_Case_10_Test()
        {
            FizzBizz service = new FizzBizz();
            service.GenerateSequence("10");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1, 2, C, 4, E, C, 7, 8, C, E");
        }

        [TestMethod]
        public void FizzBizz_Case_17_Test()
        {
            FizzBizz service = new FizzBizz();
            service.GenerateSequence("17");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z, 16, 17");
        }

        [TestMethod]
        public void FizzBizz_Case_120_Test()
        {
            FizzBizz service = new FizzBizz();
            service.GenerateSequence("120");
            var result = service.OutputSequence;
            Assert.AreEqual(result, "1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z, 16, 17, C, 19, E, C, 22, 23, C, E, 26, C, 28, 29, Z, 31, 32, C, 34, E, C, 37, 38, C, E, 41, C, 43, 44, Z, 46, 47, C, 49, E, C, 52, 53, C, E, 56, C, 58, 59, Z, 61, 62, C, 64, E, C, 67, 68, C, E, 71, C, 73, 74, Z, 76, 77, C, 79, E, C, 82, 83, C, E, 86, C, 88, 89, Z, 91, 92, C, 94, E, C, 97, 98, C, E, 101, C, 103, 104, Z, 106, 107, C, 109, E, C, 112, 113, C, E, 116, C, 118, 119, Z");
        }
    }
}
