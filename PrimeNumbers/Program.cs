using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A simple program to determine if a number is Prime
 * 
 * @author Andrei Fedorov
 * 
 */
 
namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Press Ctrl+C to terminate the program****");

            while (true)
            {
                int input;

                // ask for an integer > 1 and check user input
                Console.Write("\nPlease enter an integer greater than 1 (or Ctrl+c): ");
                if (Int32.TryParse(Console.ReadLine(), out input))
                {
                    if (input <= 1)
                    {
                        Console.WriteLine("You entered an integer less than or equal to 1");
                        continue;
                    }
                    else
                    {
                        // check if a number is prime and print an output
                        if (isPrime(input))
                        {
                            Console.WriteLine("You entered {0}, which IS a prime number", input);
                        }
                        else
                        {
                            Console.WriteLine("You entered {0}, which IS NOT a prime number", input);
                        }
                    }
                }

                else
                {
                    Console.WriteLine("This is not an integer");
                    continue;
                }
            }                
        }

        /*
         * A method that provides an algorithm
         */

        private static bool isPrime(int n)
        {
            if (n == 2)
            {
                return true;
            }
            else if (n % 2 == 0)
            {
                return false;
            }
            else
            {
                int maxFactor = (int)Math.Sqrt(n) + 1;

                for (int factor = 3; factor <= maxFactor; factor += 2)
                {
                    if (n % factor == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
