using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SimpleSorting
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
                    string[] splits = line.Split(' ');
                    double[] numbers = new double[splits.Length];
                    for (int i = 0; i < splits.Length; i++)
                    {
                        numbers[i] = Convert.ToDouble(splits[i]);
                    }
                    Array.Sort(numbers);
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write("{0:0.000}", numbers[i]);
                        if (i != (numbers.Length - 1))
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
