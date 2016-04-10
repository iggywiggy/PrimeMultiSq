using System.Collections.Generic;

namespace PrimeMultiSq.BusinessLogic.Interfaces
{
    public interface IGridCreator
    {
        IEnumerable<int[]> CreatePrimeMultiGrid(int numberOfPrimes);
    }
}