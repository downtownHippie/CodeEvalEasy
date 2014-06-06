using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SplitTheNumber
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
                    string[] splits = line.Split(' ');
                    string[] structure = splits[1].Split('+', '-');
                    string operation = splits[1].Substring(structure[0].Length, 1);
                    int number1 = Convert.ToInt32(splits[0].Substring(0, structure[0].Length));
                    int number2 = Convert.ToInt32(splits[0].Substring(structure[0].Length));
                    if (operation == "+")
                        Console.WriteLine(number1 + number2);
                    else
                        Console.WriteLine(number1 - number2);
                }
            //Console.ReadLine();
        }
    }
}
