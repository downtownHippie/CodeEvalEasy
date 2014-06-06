using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RacingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = -1;
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    char[] course = line.ToCharArray();
                    int gate = Array.IndexOf(course, '_');
                    int checkPoint = Array.IndexOf(course,'C');

                    if (checkPoint != -1)
                    {
                        if (position == -1)
                            course[checkPoint] = '|';
                        else if (checkPoint == position)
                            course[checkPoint] = '|';
                        else if (checkPoint > position)
                            course[checkPoint] = '\\';
                        else if (checkPoint < position)
                            course[checkPoint] = '/';
                        position = checkPoint;
                    }
                    else if (gate != -1)
                    {
                        if (position == -1)
                            course[gate] = '|';
                        else if (gate == position)
                            course[gate] = '|';
                        else if (gate > position)
                            course[gate] = '\\';
                        else if (gate < position)
                            course[gate] = '/';
                        position = gate;
                    }
                    Console.WriteLine(new string(course));
                }
            //Console.ReadLine();
        }
    }
}
