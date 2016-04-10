using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using NUnit.Framework;

namespace PrimeMultiSq.Calculations.UnitTests
{
    [TestClass]
    public class RowCreatorTests
    {

        [TestMethod]
        public void CreateRow_ParamPrimeLeftIsNull_ThrowsArgumentNullException()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CreateRow_ParamPrimeLeftIsNotNull_ParamPrimeTopRowIsNull_ThrowsArgumentNullException()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CreateRow_ParamPrimeLeftIsNotNull_ParamPrimeTopRowCountIs0_ThrowsArgumentNullException()
        {
            Assert.Fail();
        }

        [TestCase(2, new[] { 2 }, ExpectedResult = 1)]
        [TestCase(2, new[] { 2, 3, 5, 7, 11}, ExpectedResult = 5)]
        [TestCase(2, new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }, ExpectedResult = 10)]
        public int[] CreateRow_ReturnCountIsCorrect(int primeLeft, int[] topRowPrimes)
        {
            return null;
        }

        [TestCase(2, new[] { 2, 3, 5 }, ExpectedResult = new [] { 2, 6, 10 })]
        [TestCase(3, new[] { 2, 3, 5 }, ExpectedResult = new [] { 6, 9, 15 })]
        public int[] CreateRow_GeneratedMultiplicationsEqual(int primeLeft, int[] primeTopRow)
        {
            return null;
        }
    }
}
