using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EvenNumbers
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
                    int number = Convert.ToInt32(line);
                    if (number % 2 == 0)
                        Console.WriteLine(1);
                    else
                        Console.WriteLine(0);
                }
        }
    }
}
