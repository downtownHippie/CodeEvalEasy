using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SetIntersection
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
                    string[] sets = line.Split(';');
                    string[] set1 = sets[0].Split(',');
                    string[] set2 = sets[1].Split(',');
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < set1.Length; i++)
                    {
                        if (set2.Contains(set1[i]))
                            sb.Append(set1[i] + ",");
                    }
                    Console.WriteLine(sb.ToString().Trim(','));
                }
            //Console.ReadLine();
        }
    }
}
