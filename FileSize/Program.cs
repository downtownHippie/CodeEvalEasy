using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo(args[0]);
            Console.WriteLine(f.Length);
            //Console.ReadLine();
        }
    }
}
