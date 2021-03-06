﻿using System;
using System.Collections.Generic;
using System.Linq;
using PrimeMultiSq.Calculations.Interfaces;

namespace PrimeMultiSq.Calculations
{
    internal class PrimeGenerator : IPrimeGenerator
    {
        public int[] GetPrimes(int numberOfPrimes)
        {
            if (numberOfPrimes == 0)
                throw new ArgumentNullException(nameof(numberOfPrimes));

            var primes = new List<int>();

            if (numberOfPrimes > 0)
                primes.Add(2);

            if (numberOfPrimes > 1)
                primes.Add(3);

            for (var i = 5;; i += 2)
            {
                if (primes.Count == numberOfPrimes)
                    return primes.ToArray();

                var isPrime = primes.All(p => i%p != 0);

                if (isPrime && primes.Count < numberOfPrimes)
                    primes.Add(i);
            }
        }
    }
}