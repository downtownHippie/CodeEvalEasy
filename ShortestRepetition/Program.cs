using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ShortestRepetition
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
                    char c = line[0];
                    int i = 1;
                    while (i < line.Length)
                    {
                        if (line[i] == c)
                            break;
                        i++;
                    }
                    Console.WriteLine(i);
                }
            //Console.ReadLine();
        }
    }
}
