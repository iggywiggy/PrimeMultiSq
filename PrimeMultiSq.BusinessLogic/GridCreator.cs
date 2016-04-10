using System;
using System.Collections.Generic;
using PrimeMultiSq.BusinessLogic.Interfaces;
using PrimeMultiSq.Calculations.Interfaces;

namespace PrimeMultiSq.BusinessLogic
{
    public class GridCreator : IGridCreator
    {
        private readonly IRowCreator _rowCreator;

        public GridCreator(IRowCreator rowCreator)
        {
            _rowCreator = rowCreator;
        }

        public IEnumerable<int[]> CreatePrimeMultiGrid(int numberOfPrimes)
        {
            if (numberOfPrimes == 0)
                throw new ArgumentNullException(nameof(numberOfPrimes));

            var topRow = _rowCreator.CreateTopRow(numberOfPrimes);

            var grid = new List<int[]> {topRow};

            for (var i = 0; i < numberOfPrimes; i++)
            {
                grid.Add(_rowCreator.CreateMultiRow(topRow[i + 1], topRow));
            }

            return grid;
        }
    }
}