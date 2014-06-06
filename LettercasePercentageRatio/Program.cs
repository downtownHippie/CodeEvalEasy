using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace LettercasePercentageRatio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(" ");
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    string upper = Regex.Replace(line, "[a-z]", "");
                    string lower = Regex.Replace(line, "[A-Z]", "");
                    Console.WriteLine("lowercase: {0:0.00} uppercase: {1:0.00}", ((double)lower.Length / (double)line.Length) * 100.0, ((double)upper.Length / (double)line.Length) * 100.0);
                }
            //Console.WriteLine();
            //Console.ReadLine();
        }
    }
}
