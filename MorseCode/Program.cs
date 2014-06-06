using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MorseCode
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
                    string[] codes = line.Split(' ');
                    for (int i = 0; i < codes.Length; i++)
                    {
                        switch (codes[i])
                        {
                            case ".-":
                                Console.Write("A");
                                break;
                            case "-...":
                                Console.Write("B");
                                break;
                            case "-.-.":
                                Console.Write("C");
                                break;
                            case "-..":
                                Console.Write("D");
                                break;
                            case ".":
                                Console.Write("E");
                                break;
                            case "..-.":
                                Console.Write("F");
                                break;
                            case "--.":
                                Console.Write("G");
                                break;
                            case "....":
                                Console.Write("H");
                                break;
                            case "..":
                                Console.Write("I");
                                break;
                            case ".---":
                                Console.Write("J");
                                break;
                            case "-.-":
                                Console.Write("K");
                                break;
                            case ".-..":
                                Console.Write("L");
                                break;
                            case "--":
                                Console.Write("M");
                                break;
                            case "-.":
                                Console.Write("N");
                                break;
                            case "---":
                                Console.Write("O");
                                break;
                            case ".--.":
                                Console.Write("P");
                                break;
                            case "--.-":
                                Console.Write("Q");
                                break;
                            case ".-.":
                                Console.Write("R");
                                break;
                            case "...":
                                Console.Write("S");
                                break;
                            case "-":
                                Console.Write("T");
                                break;
                            case "..-":
                                Console.Write("U");
                                break;
                            case "...-":
                                Console.Write("V");
                                break;
                            case ".--":
                                Console.Write("W");
                                break;
                            case "-..-":
                                Console.Write("X");
                                break;
                            case "-.--":
                                Console.Write("Y");
                                break;
                            case "--..":
                                Console.Write("Z");
                                break;
                            case ".----":
                                Console.Write(1);
                                break;
                            case "..---":
                                Console.Write(2);
                                break;
                            case "...--":
                                Console.Write(3);
                                break;
                            case "....-":
                                Console.Write(4);
                                break;
                            case ".....":
                                Console.Write(5);
                                break;
                            case "-....":
                                Console.Write(6);
                                break;
                            case "--...":
                                Console.Write(7);
                                break;
                            case "---..":
                                Console.Write(8);
                                break;
                            case "----.":
                                Console.Write(9);
                                break;
                            case "-----":
                                Console.Write(0);
                                break;
                            case "":
                                Console.Write(" ");
                                break;
                        }
                    }
                    Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
