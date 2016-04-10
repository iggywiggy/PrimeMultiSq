using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeMultiSq.BusinessLogic.Interfaces;
using PrimeMultiSq.Control.Interfaces;

namespace PrimeMultiSq.Control
{
    public class MainController : IMainController
    {
        private readonly IOutput _output;
        private readonly IGridCreator _gridCreator;

        public MainController(IOutput output, IGridCreator gridCreator)
        {
            _output = output;
            _gridCreator = gridCreator;
        }

        public StringBuilder CreateGrid(int numberofPrimes)
        {
            if(numberofPrimes == 0)
                throw new ArgumentNullException(nameof(numberofPrimes));

            var grid = _gridCreator.CreatePrimeMultiGrid(numberofPrimes);
            return _output.FormatOutput(grid);
        }
    }
}
