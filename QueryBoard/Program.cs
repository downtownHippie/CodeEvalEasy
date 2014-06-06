using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace QueryBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[256, 256];
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    string command = null;
                    int setter = 0;
                    int value = 0;
                    int sum = 0;
                    string[] splits = line.Split(' ');
                    if (splits[0].StartsWith("Set"))
                    {
                        command = splits[0];
                        setter = Convert.ToInt32(splits[1]);
                        value = Convert.ToInt32(splits[2]);
                    }
                    else if (splits[0].StartsWith("Query"))
                    {
                        command = splits[0];
                        sum = 0;
                        value = Convert.ToInt32(splits[1]);
                    }
                    switch (command)
                    {
                        case "SetCol":
                            for (int i = 0; i < 256; i++)
                            {
                                matrix[i, setter] = value;
                            }
                            break;
                        case "SetRow":
                            for (int i = 0; i < 256; i++)
                            {
                                matrix[setter, i] = value;
                            }
                            break;
                        case "QueryCol":
                            for (int i = 0; i < 256; i++)
                            {
                                sum += matrix[i, value];
                            }
                            Console.WriteLine(sum);
                            break;
                        case "QueryRow":
                            for (int i = 0; i < 256; i++)
                            {
                                sum += matrix[value, i];
                            }
                            Console.WriteLine(sum);
                            break;
                    }
                }
            //Console.ReadLine();
        }
    }
}
