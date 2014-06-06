using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BeautifulStrings
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
                    string lower = line.ToLower();
                    int[] values = new int[26];
                    int sum = 0;
                    for (int i = 0; i < lower.Length; i++)
                    {
                        if (lower[i] >= 'a' && lower[i] <= 'z')
                            values[lower[i] - 'a']++;
                    }
                    Array.Sort(values);
                    Array.Reverse(values);
                    int index = 26;
                    for (int i = 0; i < values.Length; i++)
                    {
                        sum += values[i] * index--;
                    }
                    Console.WriteLine(sum);
                }
            //Console.ReadLine();
        }
    }
}
