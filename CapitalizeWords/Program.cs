using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CapitalizeWords
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
                    string[] words = line.Split(' ');
                    string[] newWords = new string[words.Length];
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i][0] >= 'a' && words[i][0] <= 'z')
                        {
                            char[] chars = words[i].ToCharArray();
                            chars[0] = Convert.ToChar(chars[0] ^ 32);
                            newWords[i] = new string(chars);
                        }
                        else
                            newWords[i] = words[i];
                    }
                    for (int i = 0; i < newWords.Length; i++)
                    {
                        Console.Write(newWords[i]);
                        if (i != (newWords.Length - 1))
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
