using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SumOfInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    sum += Convert.ToInt32(line);
                }
            Console.WriteLine(sum);
            //Console.ReadLine();
        }
    }
}
