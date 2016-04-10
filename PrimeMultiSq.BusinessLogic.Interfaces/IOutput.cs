using System.Collections.Generic;
using System.Text;

namespace PrimeMultiSq.BusinessLogic.Interfaces
{
    public interface IOutput
    {
        StringBuilder FormatOutput(IEnumerable<int[]> input);
    }
}
