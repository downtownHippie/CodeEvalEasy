using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SwapCase
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
                    char[] letters = line.ToCharArray();
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if ((letters[i] >= 'A' && letters[i] <= 'Z') || (letters[i] >= 'a' && letters[i] <= 'z'))
                        {
                            letters[i] = Convert.ToChar(letters[i] ^ 32);
                        }
                    }
                    Console.WriteLine(new string(letters));
                }
            //Console.ReadLine();
        }
    }
}
