using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input "+ n +" number of elements in the array : ");
            int[] ar = new int[n];
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write("element-" + i + ":");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Even elements are:");
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    Console.Write(ar[i] + " ");
                }
            }
            Console.WriteLine("\nThe Odd elements are: ");
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 1)
                {
                    Console.Write(ar[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
