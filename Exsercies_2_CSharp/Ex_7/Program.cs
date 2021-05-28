using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) { Console.WriteLine("A is positive"); }
            if (b % 2 == 0) { Console.WriteLine("B is positive"); }
            if(a % 2 == 0 && b % 2 == 0) { Console.WriteLine("Both is positive"); }
        }
    }
}
