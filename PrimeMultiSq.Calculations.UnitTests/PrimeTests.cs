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
        private IPrime _prime;
        [TestInitialize]
        public void TestInitialise()
        {
            _prime = new Prime();
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimesZero_Expected_ArgumentNullException()
        {
            var numberOfPrimes = 0;
            Assert.Throws(typeof (ArgumentNullException), () => _prime.GetPrimes(numberOfPrimes));
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimesOne_Expected_ReturnPrimeCountOne()
        {
            var expectedCount = 1;
            var actualCount = _prime.GetPrimes(1).Count();
            Assert.That(expectedCount == actualCount);
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimesOne_Expected_ReturnedPrimeNumber_Two()
        {
            var expectedPrime = 2;
            var actualPrime = _prime.GetPrimes(1).FirstOrDefault();
            Assert.That(expectedPrime == actualPrime);
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimesTwo_Expcted_ReturnPrimeCountTwo()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimesTwo_Expected_ReturnPrimeNumbers_TwoAndThree()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimesRandom_Expected_ReturnedCorrectNumber()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimesRandomSeedTen_Expected_ReturnedCorrectNumber()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetPrimes_ParamNumberOfPrimesRandomSeedOneHundred_Expected_ReturnedCorrectNumber()
        {
            Assert.Fail();
        }


    }
}
