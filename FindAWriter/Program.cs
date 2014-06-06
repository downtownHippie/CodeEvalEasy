using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FindAWriter
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
                    string[] splits = line.Split('|');
                    string code = splits[0];
                    string[] keys = splits[1].Split(' ');
                    char[] output = new char[keys.Length];
                    for (int i = 1; i < keys.Length; i++)
                    {
                        output[i] = code[Convert.ToInt32(keys[i]) - 1];
                    }
                    Console.WriteLine(new string(output).TrimStart('\0'));
                }
            //Console.ReadLine();
        }
    }
}
