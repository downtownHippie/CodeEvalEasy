using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace JSONMenuIDs
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
                    char[] seps = new char[] { '"', ':', ' ', '}', '{', '[', ']', ',' };
                    string[] elements = line.Split(seps);
                    int i = 0;
                    int sum = 0;
                    while (i < elements.Length)
                    {
                        if (elements[i] == "Label")
                            sum += Convert.ToInt32(elements[i + 1]);
                        i++;
                    }
                    Console.WriteLine(sum);
                }
            //Console.ReadLine();
        }
    }
}
