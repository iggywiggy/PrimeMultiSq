using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeMultiSq.Calculations.Interfaces;

namespace PrimeMultiSq.Calculations
{
    internal class Prime : IPrime
    {
        public int[] GetPrimes(int numberOfPrimes)
        {
            if(numberOfPrimes == 0)
                throw new ArgumentNullException(nameof(numberOfPrimes));

            return null;

        }
    }
}
