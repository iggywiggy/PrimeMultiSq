using System;
using System.Text;
using PrimeMultiSq.BusinessLogic.Interfaces;
using PrimeMultiSq.Control.Interfaces;

namespace PrimeMultiSq.Control
{
    public class MainController : IMainController
    {
        private readonly IGridCreator _gridCreator;
        private readonly IOutput _output;

        public MainController(IOutput output, IGridCreator gridCreator)
        {
            _output = output;
            _gridCreator = gridCreator;
        }

        public StringBuilder CreateGrid(int numberofPrimes)
        {
            if (numberofPrimes == 0)
                throw new ArgumentNullException(nameof(numberofPrimes));

            var grid = _gridCreator.CreatePrimeMultiGrid(numberofPrimes);
            return _output.FormatOutput(grid);
        }
    }
}