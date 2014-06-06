using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HiddenDigits
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
                    bool some = false;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == 'a')
                            Console.Write(0);
                        else if (line[i] == 'b')
                            Console.Write(1);
                        else if (line[i] == 'c')
                            Console.Write(2);
                        else if (line[i] == 'd')
                            Console.Write(3);
                        else if (line[i] == 'e')
                            Console.Write(4);
                        else if (line[i] == 'f')
                            Console.Write(5);
                        else if (line[i] == 'g')
                            Console.Write(6);
                        else if (line[i] == 'h')
                            Console.Write(7);
                        else if (line[i] == 'i')
                            Console.Write(8);
                        else if (line[i] == 'j')
                            Console.Write(9);
                        else if (Char.IsDigit(line[i]))
                            Console.Write(line[i]);
                        if ((line[i] >= 'a' && line[i] <= 'j') || Char.IsDigit(line[i]))
                            some = true;
                    }
                    if (!some)
                        Console.WriteLine("NONE");
                    else
                        Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
