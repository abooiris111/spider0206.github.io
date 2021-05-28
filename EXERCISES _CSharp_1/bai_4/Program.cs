using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the four number:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average of "+num1+", "+num2+", "+num3+", "+num4+" is:"+(num1+num2+num3+num4)/4);
            Console.ReadLine();
        }
    }
}
