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
        private IPrimeGenerator _primeGenerator;
        private IRowCreator _rowCreator;

        [TestInitialize]
        public void TestInitialise()
        {
            _primeGenerator = new PrimeGenerator();
            _rowCreator = new RowCreator(_primeGenerator);
        }

        [SetUp]
        public void TestCaseSetup()
        {
            _primeGenerator = new PrimeGenerator();
            _rowCreator = new RowCreator(_primeGenerator);
        }

        [TestMethod]
        public void CreateRow_ParamLeftNumberIsNot0_ParamTopRowNumbersIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws(typeof (ArgumentNullException), () => _rowCreator.CreateMultiRow(1, null));
        }

        [TestMethod]
        public void CreateRow_ParamLeftNumberIsNot0_ParamTopRowNumbersCountIs0_ThrowsArgumentNullException()
        {
            Assert.Throws(typeof (ArgumentNullException), () => _rowCreator.CreateMultiRow(1, new int[0]));
        }

        [TestCase(2, new[] {0, 2}, ExpectedResult = 2)]
        [TestCase(2, new[] {0, 2, 3, 5, 7, 11}, ExpectedResult = 6)]
        [TestCase(2, new[] {0, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29}, ExpectedResult = 11)]
        public int CreateRow_ReturnCountIsCorrect(int leftNumber, int[] topRowPrimes)
        {
            return _rowCreator.CreateMultiRow(leftNumber, topRowPrimes).Count();
        }

        [TestCase(2, new[] {0, 2, 3, 5}, ExpectedResult = new[] {2, 4, 6, 10})]
        [TestCase(3, new[] {0, 2, 3, 5}, ExpectedResult = new[] {3, 6, 9, 15})]
        [TestCase(5, new[] {0, 2, 3, 5, 7, 11}, ExpectedResult = new[] {5, 10, 15, 25, 35, 55})]
        public int[] CreateRow_GeneratedMultiplicationsEqual(int leftNumber, int[] topRowNumbers)
        {
            return _rowCreator.CreateMultiRow(leftNumber, topRowNumbers);
        }

        [TestCase(2, new[] {2, 3, 5}, ExpectedResult = true)]
        [TestCase(3, new[] {2, 3, 5}, ExpectedResult = true)]
        [TestCase(5, new[] {2, 3, 5, 7, 11}, ExpectedResult = true)]
        public bool CreateRow_FirstIndexInRowIsPrime(int leftNumber, int[] topRowNumbers)
        {
            return _rowCreator.CreateMultiRow(leftNumber, topRowNumbers)[0] == leftNumber;
        }

        [TestCase]
        public void CreateTopRow_ParamNumberOfPrimesValueZero_ThrowsArgumentNullException()
        {
            Assert.Throws(typeof (ArgumentNullException), () => _rowCreator.CreateTopRow(0));
        }

        [TestCase(2, ExpectedResult = new[] {0, 2, 3})]
        [TestCase(3, ExpectedResult = new[] {0, 2, 3, 5})]
        [TestCase(5, ExpectedResult = new[] {0, 2, 3, 5, 7, 11})]
        public int[] CreateTopRow_ReturnValuesCorrect(int numberofPrimes)
        {
            return _rowCreator.CreateTopRow(numberofPrimes);
        }

        [TestCase(2, ExpectedResult = true)]
        [TestCase(5, ExpectedResult = true)]
        [TestCase(10, ExpectedResult = true)]
        [TestCase(100, ExpectedResult = true)]
        public bool CreateToprow_ReturnCountCorrect(int numberOfPrimes)
        {
            return _rowCreator.CreateTopRow(numberOfPrimes).Count() == numberOfPrimes + 1;
        }
    }
}