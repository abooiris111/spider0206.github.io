using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine(num1 + " mod " + num2 + " = " + (num1 % num2));
            Console.ReadLine();
        }
    }
}
