using System;

namespace PrimeMultiSq.Main
{
    public class Menu
    {
        public static int DisplayMenu()
        {
            Console.WriteLine("Please input the number of primes you would like to create or 0 to exit.");
            var inputNumber = 0;


            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
            }

            return inputNumber;
        }
    }
}