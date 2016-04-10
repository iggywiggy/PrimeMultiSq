using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PrimeMultiSq.BusinessLogic.Interfaces;
using Assert = NUnit.Framework.Assert;

namespace PrimeMultiSq.BusinessLogic.UnitTests
{
    [TestClass]
    public class GridOutputTests
    {
        private IOutput _output;

        [TestInitialize]
        public void TestInitialise()
        {
            _output = new GridOutput();
        }

        [SetUp]
        public void TestCaseSetup()
        {
            _output = new GridOutput();
        }

        [TestMethod]
        public void FormatOutput_ParamGridValueNull_ThrowsArgumentNullException()
        {
            Assert.Throws(typeof (ArgumentNullException), () => _output.FormatOutput(null));
        }

        [TestMethod]
        public void FormatOutput_ParamGridValueZeroEntries_ThrowArgumentNullException()
        {
            Assert.Throws(typeof (ArgumentNullException), () => _output.FormatOutput(new List<int[]>()));
        }


        [TestCase(0,ExpectedResult = '|')]
        [TestCase(3,ExpectedResult = '0')]
        
        public char FormatOutput_NumberOfLinesReturned(int charAtIndex)
        {
            string output = _output.FormatOutput(CreateGrid()).ToString();
            return output[charAtIndex];
        }

        private IEnumerable<int[]> CreateGrid()
        {
            return new List<int[]>
            {
                new[] {0, 2, 3},
                new[] {2, 4, 6},
                new[] {3, 6, 9}
            };
        }

    }
}
