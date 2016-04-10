using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiSq.Calculations.Interfaces
{
    public interface IRowCreator
    {
        int[] CreateRow(int primeLeft, int[] primeTopRow);
    }
}
