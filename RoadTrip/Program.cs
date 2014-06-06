using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RoadTrip
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
                    int distance = 0;
                    string[] cityDistances = line.Split(';');
                    List<int> distances = new List<int>();
                    for (int i = 0; i < cityDistances.Length; i++)
                    {
                        if (!String.IsNullOrEmpty(cityDistances[i]))
                            distances.Add(Convert.ToInt32(cityDistances[i].Split(',')[1]));
                    }
                    distances.Sort();
                    for (int i = 0; i < distances.Count; i++)
                    {
                        Console.Write(distances[i] - distance);
                        distance += (distances[i] - distance);
                        if (i < (distances.Count - 1))
                            Console.Write(",");
                    }
                    Console.WriteLine();
                }
            //Console.ReadLine();
        }
    }
}
