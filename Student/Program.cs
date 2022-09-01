using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text=System.IO.File.ReadAllText(@"E:\Projects\RainbowSchools.txt");
            System.Console.WriteLine(text);
            Console.ReadLine();

        }
    }
}
