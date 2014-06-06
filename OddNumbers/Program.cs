using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
            //Console.ReadLine();
        }
    }
}
