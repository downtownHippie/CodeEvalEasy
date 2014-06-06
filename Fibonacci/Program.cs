using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    int n = Convert.ToInt32(line);
                    Console.WriteLine(Fibb(n));
                }
            //Console.ReadLine();
        }

        public static int Fibb(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fibb(n - 1) + Fibb(n - 2);
        }
    }
}
