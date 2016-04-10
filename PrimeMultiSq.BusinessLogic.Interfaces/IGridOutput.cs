using System.Collections.Generic;
using System.Text;

namespace PrimeMultiSq.BusinessLogic.Interfaces
{
    public interface IGridOutput
    {
        StringBuilder FormatOutput(IEnumerable<int[]> grid);
    }
}
