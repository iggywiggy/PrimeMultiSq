using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiSq.Main
{
    public class Menu
    {
        public static int DisplayMenu()
        {
            Console.WriteLine("Please input the number of primes you would like to create or 0 to exit.");
            return int.Parse(Console.ReadLine());
        }

    }
}
