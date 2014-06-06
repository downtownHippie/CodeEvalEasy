using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SelfDescribingNumbers
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
                    bool selfie = true;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        int count = 0;
                        for (int j = 0; j < digits.Length; j++)
                        {
                            if ((digits[j] - '0') == i)
                                count++;
                        }
                        if (count != (digits[i] - '0'))
                        {
                            selfie = false;
                            Console.WriteLine(0);
                            break;
                        }
                    }
                    if (selfie)
                        Console.WriteLine(1);
                }
            //Console.ReadLine();
        }
    }
}
