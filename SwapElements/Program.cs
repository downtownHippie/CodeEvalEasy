using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SwapElements
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
                    string[] splits = line.Split(':');
                    string[] numbers = splits[0].Trim().Split(' ');
                    string[] commands = splits[1].Trim().Split(',');
                    for (int i = 0; i < commands.Length; i++)
                    {
                        string[] commandsSplits = commands[i].Split('-');
                        int index1 = Convert.ToInt32(commandsSplits[0]);
                        int index2 = Convert.ToInt32(commandsSplits[1]);
                        string holder = numbers[index1];
                        numbers[index1] = numbers[index2];
                        numbers[index2] = holder;   
                    }
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i]);
                        if (i < (numbers.Length - 1))
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
