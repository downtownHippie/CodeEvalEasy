using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MulitplesOfANumber
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
                    //Console.WriteLine(line);
                    string[] splits = line.Split(',');
                    int x = Convert.ToInt32(splits[0]);
                    int n = Convert.ToInt32(splits[1]);
                    int product = 0;
                    int i = 1;
                    while (product < x)
                    {
                        product = n * i++;
                    }
                    Console.WriteLine(product);
                }
            //Console.ReadLine();
        }
    }
}
