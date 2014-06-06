using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lowercase
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
                    //char[] chars = line.ToCharArray();
                    //for (int i = 0; i < chars.Length; i++)
                    //{
                    //    if ((chars[i] >= 65) && (chars[i] <= 90))
                    //        chars[i] = Convert.ToChar((int)chars[i] ^ 32);
                    //}
                    //Console.WriteLine(chars);
                    Console.WriteLine(line.ToLower());
                }
            //Console.ReadLine();
        }
    }
}
