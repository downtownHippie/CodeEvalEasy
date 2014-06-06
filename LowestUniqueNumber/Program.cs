using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LowestUniqueNumber
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
                    string[] numbersS = line.Split(' ');
                    int[] numbers = new int[numbersS.Length];
                    for (int i = 0; i < numbersS.Length; i++)
                    {
                        numbers[i] = Convert.ToInt32(numbersS[i]);
                    }
                    int[] papers = new int[10];
                    int lowest = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int number = numbers[i];
                        papers[number]++;
                    }
                    for (int i = papers.Length -1 ; i >= 0; i--)
                    {
                        if (papers[i] == 1)
                            lowest = i;
                    }
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == lowest)
                        {
                            Console.WriteLine(i + 1);
                            break;
                        }
                    }
                    if (lowest == 0)
                        Console.WriteLine(0);
                   
                }
            //Console.ReadLine();
        }
    }
}
