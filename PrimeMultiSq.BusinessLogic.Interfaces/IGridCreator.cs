using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiSq.BusinessLogic.Interfaces
{
    public interface IGridCreator
    {
        int[,] CreateGrid(int numberOfPrimes);
    }
}
