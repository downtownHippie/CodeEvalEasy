using System;
using System.Text;
using System.IO;

namespace ReverseWords
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
                    StringBuilder newLine = new StringBuilder();
                    for (int i = splits.Length - 1; i >= 0 ; i--)
                    {
                        newLine.Append(splits[i]);
                        if (i != 0)
                            newLine.Append(" ");
                    }
                    Console.WriteLine(newLine.ToString());
                }
            //Console.ReadLine();
        }
    }
}
