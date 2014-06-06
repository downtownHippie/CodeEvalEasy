using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ArmstrongNumbers
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
                    char[] digits = line.ToCharArray();
                    int sum = 0;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        sum += (int)Math.Pow((digits[i] - '0'), digits.Length);
                    }
                    Console.WriteLine(sum == Convert.ToInt32(line));
                }
            //Console.ReadLine();
        }
    }
}
