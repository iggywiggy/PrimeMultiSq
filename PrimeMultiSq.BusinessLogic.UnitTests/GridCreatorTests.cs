using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using PrimeMultiSq.BusinessLogic.Interfaces;


namespace PrimeMultiSq.BusinessLogic.UnitTests
{
    [TestClass]
    public class GridCreatorTests
    {

        private IGridCreator _gridCreator;

        [TestInitialize]
        public void TestIntiliase()
        {
            _gridCreator = new GridCreator();
        }

        [TestMethod]
        public void CreateGrid_ParamNumberOfPrimesValueZero_ThrowsArgumentNullException()
        {
            Assert.Fail();
        }

        



        [TestMethod]
        [TestCase(0,0,1, ExpectedResult = 0)]
        [TestCase(0,3,3, ExpectedResult = 10)]
        [TestCase(3,2,3, ExpectedResult = 15)]
        [TestCase(2,4,5, ExpectedResult = 21)]
        [TestCase(2,12,37, ExpectedResult = 444 )]
        public int CreateGrid_IndexValueInGridCorrect(int leftIndex, int rightIndex, int numberOfPrimes)
        {
            return 1;
        }

        [TestMethod]
        [TestCase(2, ExpectedResult = 9)]
        [TestCase(5, ExpectedResult = 36)]
        [TestCase(10, ExpectedResult = 121)]
        [TestCase(100,ExpectedResult = 12321)]
        public int CreateGrid_TotalNumberOfCellsInGrid(int numberOfPrimes)
        {
            return 0;
        }

      






    }



}

