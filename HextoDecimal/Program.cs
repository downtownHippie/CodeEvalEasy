using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HextoDecimal
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
                        int value;
                        switch (digits[i])
                        {
                            case 'f':
                                value = 15;
                                break;
                            case 'e':
                                value = 14;
                                break;
                            case 'd':
                                value = 13;
                                break;
                            case 'c':
                                value = 12;
                                break;
                            case 'b':
                                value = 11;
                                break;
                            case 'a':
                                value = 10;
                                break;
                            default:
                                value = digits[i] - '0';
                                break;
                        }
                        sum += value * (int)Math.Pow(16,digits.Length - (i + 1));
                    }
                    Console.WriteLine(sum);
                }
            //Console.ReadLine();
        }
    }
}
