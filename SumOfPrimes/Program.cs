using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int primes = 0;
            int sum = 0;

            for (int i = 2; i < Int32.MaxValue; i++)
            {
                if (isPrime(i))
                {
                    sum += i;
                    primes++;
                    //Console.WriteLine("{0} {1} {2}", i, sum, primes);
                    if (primes == 1000)
                        break;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static bool isPrime(int number)
        {
            if (number == 2 || number == 3)
                return true;
            else if ((number % 2 == 0) || (number % 3 == 0))
                return false;
            int i = 5;
            int w = 2;
            while (i * i <= number)
            {
                if (number % i == 0)
                    return false;
                i += w;
                w = 6 - w;
            }
            return true;
        }
    }
}
