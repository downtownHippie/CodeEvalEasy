using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RomanNumerals
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
                    StringBuilder numeral = new StringBuilder();
                    int value = Convert.ToInt32(line);
                    while (value > 0)
                    {
                        if (value >= 1000) { numeral.Append("M"); value -= 1000; }
                        else if (value >= 900) { numeral.Append("CM"); value -= 900; }
                        else if (value >= 500) { numeral.Append("D"); value -= 500; }
                        else if (value >= 400) { numeral.Append("CD"); value -= 400; }
                        else if (value >= 100) { numeral.Append("C"); value -= 100; }
                        else if (value >= 90) { numeral.Append("XC"); value -= 90; }
                        else if (value >= 50) { numeral.Append("L"); value -= 50; }
                        else if (value >= 40) { numeral.Append("XL"); value -= 40; }
                        else if (value >= 10) { numeral.Append("X"); value -= 10; }
                        else if (value >= 9) { numeral.Append("IX"); value -= 9; }
                        else if (value >= 5) { numeral.Append("V"); value -= 5; }
                        else if (value >= 4) { numeral.Append("IV"); value -= 4; }
                        else if (value >= 1) { numeral.Append("I"); value -= 1; }
                    }
                    Console.WriteLine(numeral.ToString());
                }
            //Console.ReadLine();
        }
    }
}
