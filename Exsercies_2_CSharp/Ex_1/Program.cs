using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_1
{
    class Program
    {
        static int func(int x)
        {
            int c = x * x - 2 * x + 1;
            return c;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                Console.Write(func(i) + " ");
            }
            Console.ReadLine();
        }
    }
}
