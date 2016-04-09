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

            var primes = new List<int>();

            if (numberOfPrimes > 0)
                primes.Add(2);

            if(numberOfPrimes > 1)
                primes.Add(3);

            return primes.ToArray();
        }
    }
}
