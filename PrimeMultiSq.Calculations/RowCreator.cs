using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeMultiSq.Calculations.Interfaces;

namespace PrimeMultiSq.Calculations
{
    internal class RowCreator : IRowCreator
    {
        public int[] CreateRow(int primeLeft, int[] primeTopRow)
        {
            if(primeLeft == 0)
                throw new ArgumentNullException(nameof(primeLeft));

            if(primeTopRow == null || primeTopRow.Count() == 0)
                throw new ArgumentNullException(nameof(primeTopRow));

            return null;
        }
    }
}
