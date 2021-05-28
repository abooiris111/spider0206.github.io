using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int dou = Convert.ToInt32(Console.ReadLine());
            Double(ref dou);
            Console.WriteLine(dou);
            Console.ReadLine();
        }
        static void Double(ref int dou)
        {
            dou = dou * 2;
        }
    }
}
