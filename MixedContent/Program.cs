using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MixedContent
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
                    List<string> elements = line.Split(',').ToList();
                    List<string> words = new List<string>();
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (Char.IsLetter(elements[i], 0))
                        {
                            words.Add(elements[i]);
                            elements.RemoveAt(i);
                            i--;
                        }
                    }
                    for (int i = 0; i < words.Count; i++)
                    {
                        Console.Write(words[i]);
                        if (i != (words.Count - 1))
                            Console.Write(",");
                    }
                    if ((words.Count != 0) && (elements.Count != 0))
                        Console.Write("|");
                    for (int i = 0; i < elements.Count; i++)
                    {
                        Console.Write(elements[i]);
                        if (i != (elements.Count - 1))
                            Console.Write(",");
                    }
                    Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
