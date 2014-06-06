using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MajorElement
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
                    string[] numbers = line.Split(',');
                    Dictionary<int, int> dict = new Dictionary<int, int>();
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int number = Convert.ToInt32(numbers[i]);
                        if (dict.ContainsKey(number))
                            dict[number] += 1;
                        else
                            dict[number] = 1;
                    }
                    var sorted = from pair in dict
                                           orderby pair.Value descending
                                           select pair;
                    if (sorted.First().Value > (numbers.Length / 2))
                        Console.WriteLine(sorted.First().Key);
                    else
                        Console.WriteLine("None");
                }
            //Console.ReadLine();
        }
    }
}
