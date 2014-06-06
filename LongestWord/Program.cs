using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LongestWord
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
                    string[] words = line.Split(' ');
                    string longest = words[0];
                    int i = 1;
                    while (i < words.Length)
                    {
                        if (words[i].Length > longest.Length)
                            longest = words[i];
                        i++;
                    }
                    Console.WriteLine(longest);
                }
            //Console.ReadLine();
        }
    }
}
