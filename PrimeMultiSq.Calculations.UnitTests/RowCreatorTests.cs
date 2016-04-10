using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PrimeMultiSq.Calculations.Interfaces;
using Assert = NUnit.Framework.Assert;

namespace PrimeMultiSq.Calculations.UnitTests
{
    [TestClass]
    public class RowCreatorTests
    {
        private IRowCreator _rowCreator;

        [TestInitialize]
        public void TestInitialise()
        {
            _rowCreator = new RowCreator();
        }

        [SetUp]
        public void TestCaseSetup()
        {
            _rowCreator = new RowCreator();
        }


        [TestMethod]
        public void CreateRow_ParamPrimeLeftIs0_ThrowsArgumentNullException()
        {
            Assert.Throws(typeof (ArgumentNullException), () => _rowCreator.CreateRow(0, new[] {1}));
        }

        [TestMethod]
        public void CreateRow_ParamPrimeLeftIsNot0_ParamPrimeTopRowIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws(typeof (ArgumentNullException), () => _rowCreator.CreateRow(1, null));
        }

        [TestMethod]
        public void CreateRow_ParamPrimeLeftIsNot0_ParamPrimeTopRowCountIs0_ThrowsArgumentNullException()
        {
            Assert.Throws(typeof (ArgumentNullException), () => _rowCreator.CreateRow(1, new int[0]));
        }

        [TestCase(2, new[] {2}, ExpectedResult = 2)]
        [TestCase(2, new[] {2, 3, 5, 7, 11}, ExpectedResult = 6)]
        [TestCase(2, new[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29}, ExpectedResult = 11)]
        public int CreateRow_ReturnCountIsCorrect(int primeLeft, int[] topRowPrimes)
        {
            return _rowCreator.CreateRow(primeLeft, topRowPrimes).Count();
        }

        [TestCase(2, new[] {2, 3, 5}, ExpectedResult = new[] {2, 4, 6, 10})]
        [TestCase(3, new[] {2, 3, 5}, ExpectedResult = new[] {3, 6, 9, 15})]
        [TestCase(5, new[] {2, 3, 5, 7, 11}, ExpectedResult = new[] {5, 10, 15, 25, 35, 55})]
        public int[] CreateRow_GeneratedMultiplicationsEqual(int primeLeft, int[] primeTopRow)
        {
            return _rowCreator.CreateRow(primeLeft, primeTopRow);
        }

        [TestCase(2, new[] {2, 3, 5}, ExpectedResult = true)]
        [TestCase(3, new[] {2, 3, 5}, ExpectedResult = true)]
        [TestCase(5, new[] {2, 3, 5, 7, 11}, ExpectedResult = true)]
        public bool CreateRow_FirstIndexInRowIsPrime(int primeLeft, int[] primeTopRow)
        {
            return _rowCreator.CreateRow(primeLeft, primeTopRow)[0] == primeLeft;
        }
    }
}
