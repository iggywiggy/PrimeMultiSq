namespace PrimeMultiSq.Calculations.Interfaces
{
    public interface IRowCreator
    {
        int[] CreateMultiRow(int primeLeft, int[] primeTopRow);
        int[] CreateTopRow(int numberOfPrimes);
    }
}
