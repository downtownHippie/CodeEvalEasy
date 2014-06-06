using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int largest = 0;
            for (int number = 0; number < max; number++)
            {
                if (isPrime(number))
                {
                    int r = 0;
                    int s = number;
                    while (s > 0)
                    {
                        r = r * 10 + s % 10;
                        s /= 10;
                    }

                    if (r == number)
                        largest = r;
                }
            }
            Console.WriteLine(largest);
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
