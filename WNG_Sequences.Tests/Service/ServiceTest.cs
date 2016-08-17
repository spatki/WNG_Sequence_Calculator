using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WNG_Sequences.Service;

namespace WNG_Sequences.Tests.Service
{
    [TestClass]
    public class ServiceTest
    {
        SequenceService _service;

        [TestInitialize]
        public void Initialize()
        {
            _service = new SequenceService();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase1_Test()
        {
            _service.GenerateSequence("A123");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase2_Test()
        {
            _service.GenerateSequence("A1 23");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase3_Test()
        {
            _service.GenerateSequence("12  3");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotANumberCase4_Test()
        {
            _service.GenerateSequence("12.3");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberOutOfLowerRange_Test()
        {
            _service.GenerateSequence("0");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberOutOfUpperRange1_Test()
        {
            _service.GenerateSequence("5001");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberOutOfUpperRange2_Test()
        {
            _service.GenerateSequence("30011");
        }
    }
}
