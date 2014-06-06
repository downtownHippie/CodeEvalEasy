using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 12; x++)
            {
                for (int y = 1; y <= 12; y++)
                {
                    string productS = (x * y).ToString();
                    if (y == 1)
                        Console.Write(productS);
                    else
                        Console.Write(productS.PadLeft(4));
                }
                Console.WriteLine();
            }
            //Console.ReadLine();
        }
    }
}
