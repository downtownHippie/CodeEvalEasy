using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HappyNumbers
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
                    int num = Convert.ToInt32(line);
                    List<int> numbers = new List<int>();
                    while (num != 1)
                    {
                        char[] digits = num.ToString().ToCharArray();
                        int sum = 0;
                        for (int i = 0; i < digits.Length; i++)
                        {
                            sum += (int)Math.Pow(digits[i] - '0', 2);
                        }
                        num = sum;
                        if (num == 1)
                            break;
                        if (numbers.Contains(num))
                            break;
                        numbers.Add(num);
                    }
                    if (num == 1)
                        Console.WriteLine(1);
                    else
                        Console.WriteLine(0);
                }
            //Console.ReadLine();
        }
    }
}
