using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using PrimeMultiSq.BusinessLogic.Interfaces;
using PrimeMultiSq.Calculations;
using PrimeMultiSq.Calculations.Interfaces;


namespace PrimeMultiSq.BusinessLogic.UnitTests
{
    [TestClass]
    public class GridCreatorTests
    {
        private IGridCreator _gridCreator;
        private IRowCreator _rowCreator;
        private IPrimeGenerator _primeGenerator;

        private void CreateInstances()
        {
            _primeGenerator = new PrimeGenerator();
            _rowCreator = new RowCreator(_primeGenerator);
            _gridCreator = new GridCreator(_rowCreator);
        }

        [TestInitialize]
        public void TestIntiliase()
        {
            CreateInstances();
        }

        [SetUp]
        public void TestCaseSetup()
        {
            CreateInstances();
        }

        [TestMethod]
        public void CreateGrid_ParamNumberOfPrimesValueZero_ThrowsArgumentNullException()
        {
            Assert.Throws(typeof (ArgumentNullException), () => _gridCreator.CreatePrimeMultiGrid(0));
        }
        
        [TestCase(0,0,1, ExpectedResult = 0)]
        [TestCase(1,3,3, ExpectedResult = 10)]
        [TestCase(3,2,3, ExpectedResult = 15)]
        [TestCase(2,4,5, ExpectedResult = 21)]
        [TestCase(2,12,37, ExpectedResult = 111)]
        [TestCase(5,36,37, ExpectedResult = 1661)]
        [TestCase(7,7,7, ExpectedResult = 289)]
        public int CreateGrid_IndexValueInGridCorrect(int leftIndex, int rightIndex, int numberOfPrimes)
        {
            var grid = _gridCreator.CreatePrimeMultiGrid(numberOfPrimes);
            return grid.ToArray()[leftIndex][rightIndex];
        }
        
        [TestCase(2, ExpectedResult = 9)]
        [TestCase(5, ExpectedResult = 36)]
        [TestCase(10, ExpectedResult = 121)]
        [TestCase(100,ExpectedResult = 10201)]
        public int CreateGrid_TotalNumberOfCellsInGrid(int numberOfPrimes)
        {
            var grid = _gridCreator.CreatePrimeMultiGrid(numberOfPrimes);
            return grid.Sum(row => row.Count());
        }
    }
}

