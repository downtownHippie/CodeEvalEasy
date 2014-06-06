using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UniqueElements
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
                    string[] splits = line.Split(',');
                    string that = string.Empty;
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < splits.Length; i++)
                    {
                        if (splits[i] != that)
                            sb.Append(splits[i] + ",");
                        that = splits[i];
                    }
                    Console.WriteLine(sb.ToString().Trim(','));
                }
            //Console.ReadLine();
        }
    }
}
