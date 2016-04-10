using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeMultiSq.Calculations.Interfaces;
using Assert = NUnit.Framework.Assert;

namespace PrimeMultiSq.Calculations.UnitTests
{
    [TestClass]
    public class PrimeTests
    {
        private IPrimeGenerator _primeGenerator;

        [TestInitialize]
        public void TestInitialise()
        {
            _primeGenerator = new PrimeGenerator();
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimesZero_Expected_ArgumentNullException()
        {
            var numberOfPrimes = 0;
            Assert.Throws(typeof (ArgumentNullException), () => _primeGenerator.GetPrimes(numberOfPrimes));
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimes_1_Expected_ReturnPrimeCount_1()
        {
            var expectedCount = 1;
            var actualCount = _primeGenerator.GetPrimes(1).Count();
            Assert.That(expectedCount == actualCount);
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimes_1_Expected_ReturnedPrimeNumber_2()
        {
            var expectedPrime = 2;
            var actualPrime = _primeGenerator.GetPrimes(1).FirstOrDefault();
            Assert.That(expectedPrime == actualPrime);
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimes_2_Expected_ReturnPrimeCount_2()
        {
            var expectedCount = 2;
            var actualCount = _primeGenerator.GetPrimes(2).Count();
            Assert.That(expectedCount == actualCount);
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimes_2_Expected_ReturnPrimeNumbers_2And3()
        {
            var expectedPrimes = new[] {2, 3};
            var actualPrimes = _primeGenerator.GetPrimes(2);
            CollectionAssert.AreEqual(expectedPrimes,actualPrimes);
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimes_23_Expected_ReturnedCorrectNumber()
        {
            var expectedCount = 23;
            var actualCount = _primeGenerator.GetPrimes(expectedCount).Count();
            Assert.That(expectedCount == actualCount);
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimes_550_Expected_ReturnedCorrectNumber()
        {
            var expectedCount = 550;
            var actualCount = _primeGenerator.GetPrimes(expectedCount).Count();
            Assert.That(expectedCount == actualCount);
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimes_12_Expected_ReturnedCorrectNumber()
        {
            var expectedCount = 12;
            var actualCount = _primeGenerator.GetPrimes(expectedCount).Count();
            Assert.That(expectedCount == actualCount);
        }

    }
}
