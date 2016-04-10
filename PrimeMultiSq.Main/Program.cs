using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeMultiSq.Control;
using PrimeMultiSq.Control.Interfaces;

namespace PrimeMultiSq.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = DiContainer.Instance.ResolveMainController();
            int numberOfPrimes = 0;

            do
            {
                numberOfPrimes = Menu.DisplayMenu();

                Console.Write(controller.CreateGrid(numberOfPrimes));

            } while (numberOfPrimes != 0);
        }
    }
}
