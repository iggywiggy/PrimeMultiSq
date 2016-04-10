using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiSq.Calculations.Interfaces
{
    public interface IPrimeGenerator
    {
        int[] GetPrimes(int numberOfPrimes);
    }


}
