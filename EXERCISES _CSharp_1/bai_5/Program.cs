using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            while (a!=0)
            {
                b = b * 10;
                b = b + a % 10;
                a = a / 10;
            }
            Console.WriteLine("The number in reverse order is : " + b);
            Console.ReadLine();
        }
    }
}
