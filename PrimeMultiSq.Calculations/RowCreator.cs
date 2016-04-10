using System;
using System.Linq;
using PrimeMultiSq.Calculations.Interfaces;

namespace PrimeMultiSq.Calculations
{
    internal class RowCreator : IRowCreator
    {
        private readonly IPrimeGenerator _primeGenerator;

        public RowCreator(IPrimeGenerator primeGenerator)
        {
            _primeGenerator = primeGenerator;
        }

        public int[] CreateMultiRow(int leftNumber, int[] topRowNumbers)
        {
            if (topRowNumbers == null || topRowNumbers.Count() == 0)
                throw new ArgumentNullException(nameof(topRowNumbers));

            var row = new int[topRowNumbers.Length];

            row[0] = leftNumber;

            for (var i = 1; i < row.Length; i++)
            {
                row[i] = topRowNumbers[i]*leftNumber;
            }

            return row;
        }

        public int[] CreateTopRow(int numberOfPrimes)
        {
            if (numberOfPrimes == 0)
                throw new ArgumentNullException(nameof(numberOfPrimes));

            var primes = _primeGenerator.GetPrimes(numberOfPrimes);

            var topRow = new int[1 + numberOfPrimes];

            for (var i = 1; i < topRow.Count(); i++)
            {
                topRow[i] = primes[i - 1];
            }

            return topRow;
        }
    }
}