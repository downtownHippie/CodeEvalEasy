using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//thanks to my wife for figuring out the algorithm...

namespace DataRecovery
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
                    //Console.WriteLine(line);
                    string[] splits = line.Split(';');
                    string[] origSentence = splits[0].Split(' ');
                    string[] newSentence = new string[origSentence.Length];
                    string[] hintsS = splits[1].Split(' ');
                    int[] hints = new int[hintsS.Length];
                    int[] numbers = new int[hints.Length + 1];
                    for (int i = 0; i < hints.Length; i++)
                        hints[i] = Convert.ToInt32(hintsS[i]);
                    for (int i = 0; i < hints.Length; i++)
                    {
                        newSentence[hints[i] - 1] = origSentence[i];
                        numbers[hints[i] - 1] = 1;
                    }
                    int missingNumber = Array.FindIndex(numbers, x => x == 0);
                    newSentence[missingNumber] = origSentence[origSentence.Length - 1];
                    for (int i = 0; i < newSentence.Length; i++)
                    {
                        Console.Write(newSentence[i]);
                        if (i < (newSentence.Length - 1))
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
