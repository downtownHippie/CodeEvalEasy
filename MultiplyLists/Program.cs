using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MultiplyLists
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
                    string[] splits = line.Split('|');
                    string[] set1 = splits[0].Trim().Split(' ');
                    string[] set2 = splits[1].Trim().Split(' ');
                    for (int i = 0; i < set1.Length; i++)
                    {
                        int num1 = Convert.ToInt32(set1[i]);
                        int num2 = Convert.ToInt32(set2[i]);
                        Console.Write(num1 * num2);
                        if (i < (set1.Length - 1))
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
