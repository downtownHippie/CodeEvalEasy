using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CompressedSequence
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
                    string[] numbers = line.Split(' ');
                    int element = Convert.ToInt32(numbers[0]);
                    int count = 1;
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (element == Convert.ToInt32(numbers[i]))
                            count++;
                        else
                        {
                            Console.Write("{0} {1}", count, element);
                            count = 1;
                            element = Convert.ToInt32(numbers[i]);
                            if (i != (numbers.Length - 1))
                                Console.Write(" ");
                        }

                    }
                    if (count == 1)
                        Console.Write(" {0} {1}", count, element);
                    else
                        Console.Write("{0} {1}", count, element);
                    Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
