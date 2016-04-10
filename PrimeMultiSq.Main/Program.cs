using System;
using PrimeMultiSq.Control;

namespace PrimeMultiSq.Main
{
    internal class Program
    {
        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Environment.Exit(1);
        }

        private static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;


            var controller = DiContainer.Instance.ResolveMainController();
            var numberOfPrimes = 0;

            do
            {
                numberOfPrimes = Menu.DisplayMenu();

                if (numberOfPrimes == 0)
                    Environment.Exit(0);
                Console.WriteLine();
                Console.WriteLine("Prime Multiplication Grid");
                Console.WriteLine();
                Console.Write(controller.CreateGrid(numberOfPrimes));
            } while (numberOfPrimes != 0);
        }
    }
}