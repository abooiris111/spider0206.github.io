using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0) { Console.WriteLine("Goodbye!"); continue; }
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 0) { Console.WriteLine("You cannot divide by 0"); }
                if (a != 0 && b != 0)
                {
                    Console.WriteLine("The division is " + a / b);
                    Console.WriteLine("The division is " + a % b);
                }
            }
        }
    }
}
