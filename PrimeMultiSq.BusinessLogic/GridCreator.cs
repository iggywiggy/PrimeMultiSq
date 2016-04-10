using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeMultiSq.BusinessLogic.Interfaces;

namespace PrimeMultiSq.BusinessLogic
{
    public class GridCreator : IGridCreator
    {
        public IEnumerable<int[]> CreateGrid(int numberOfPrimes)
        {
            if(numberOfPrimes == 0)
                throw new ArgumentNullException(nameof(numberOfPrimes));

            return null;
        }
    }
}
