using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int j = a;
            while (j<=b)
            {
                Console.Write(j + " ");
                j++;
            }
            Console.WriteLine();
            int k = a;
            do
            {
                Console.Write(k + " ");
                k++;
            } while (k<=b);
            Console.ReadLine();
        }
    }
}
