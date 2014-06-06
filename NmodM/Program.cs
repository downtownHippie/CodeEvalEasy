using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NmodM
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
                    string[] values = line.Split(',');
                    int n = Convert.ToInt32(values[0]);
                    int m = Convert.ToInt32(values[1]);
                    int looper = 0;
                    while (n - (looper * m) >= m)
                    {
                        looper++;
                    }
                    Console.WriteLine(n - looper * m);
                }
            Console.ReadLine();
        }
    }
}
