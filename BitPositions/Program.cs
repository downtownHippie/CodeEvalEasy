using System;
using System.IO;

namespace BitPositions
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
                    string[] splits = line.Split(',');
                    int value = Convert.ToInt32(splits[0]);
                    int p1 = Convert.ToInt32(splits[1]);
                    int p2 = Convert.ToInt32(splits[2]);
                    string valueS = Convert.ToString(value, 2);
                    string pos1 = valueS.Substring(valueS.Length - p1, 1);
                    string pos2 = valueS.Substring(valueS.Length - p2, 1);
                    if (pos1 == pos2)
                        Console.WriteLine("true");
                    else
                        Console.WriteLine("false");
                }
            //Console.ReadLine();
        }
    }
}