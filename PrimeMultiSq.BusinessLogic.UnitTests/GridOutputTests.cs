using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeMultiSq.BusinessLogic.Interfaces;
using Assert = NUnit.Framework.Assert;

namespace PrimeMultiSq.BusinessLogic.UnitTests
{
    [TestClass]
    public class GridOutputTests
    {
        private IGridOutput _gridOutput;

        [TestMethod]
        public void FormatOutput_ParamGridValueNull_ThrowsArgumentNullException()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void FormatOutput_ParamGridValueZeroEntries_ThrowArgumentNullException()
        {
            Assert.Fail();
        }
    }
}
