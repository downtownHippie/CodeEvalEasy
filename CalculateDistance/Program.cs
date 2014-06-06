using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CalculateDistance
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
                    int indexOfP = line.IndexOf(')');
                    string pointA = line.Substring(1, indexOfP - 1);
                    string pointB = line.Substring(indexOfP + 3).TrimEnd(')');
                    int indexOfC = pointA.IndexOf(',');
                    int x1 = Convert.ToInt32(pointA.Substring(0, indexOfC));
                    int y1 = Convert.ToInt32(pointA.Substring(indexOfC + 2));
                    indexOfC = pointB.IndexOf(',');
                    int x2 = Convert.ToInt32(pointB.Substring(0, indexOfC));
                    int y2 = Convert.ToInt32(pointB.Substring(indexOfC + 2));
                    double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                    Console.WriteLine(distance);
                }
        }
    }
}
