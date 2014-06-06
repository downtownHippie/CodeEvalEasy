using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            //FileStream inFile = new FileStream(args[0], FileMode.Open);
            //StreamReader sReader = new StreamReader(inFile);
            //string line;
            //while ((line = sReader.ReadLine()) != null)
            {
                string line = reader.ReadLine();
                if (line == null)
                    continue;
                int A, B, N;
                string[] splitter;
                splitter = line.Split(' ');
                A = Convert.ToInt32(splitter[0]);
                B = Convert.ToInt32(splitter[1]);
                N = Convert.ToInt32(splitter[2]);

                for (int i = 1; i <= N ; i++)
                {
                    if ((i % A == 0) && (i % B == 0))
                        Console.Write("FB");
                    else if (i % A == 0)
                        Console.Write("F");
                    else if (i % B == 0)
                        Console.Write("B");
                    else
                        Console.Write(i);

                    if (i != N)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            //sReader.Close();

            Console.ReadLine();
        }
    }
}
