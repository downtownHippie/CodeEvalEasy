using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SumOfDigits
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
                     int sum = 0;
                     //char[] chars = line.ToCharArray();
                     foreach (char item in line)
                     {
                         sum += item - '0';
                     }
                     Console.WriteLine(sum);
                 }
             //Console.ReadLine();
        }
    }
}
