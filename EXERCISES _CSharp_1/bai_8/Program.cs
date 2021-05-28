using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input " + n + " number of elements in the array : ");
            int[] ar1 = new int[n];
            for (int i = 0; i < ar1.Length; i++)
            {
                Console.Write("element-" + i + ":");
                ar1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input the value to be inserted :");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted :");
            int pos = Convert.ToInt32(Console.ReadLine());
            int[] ar2 = new int[n+1];
            for (int i = 0; i < ar2.Length; i++)
            {
                if (i < pos - 1) { ar2[i] = ar1[i]; }
                if (i == pos - 1) { ar2[i] = value; }
                if (i > pos - 1) { ar2[i] = ar1[i - 1]; }
            }
            Console.WriteLine("The current list of the array :");
            for (int i = 0; i < ar1.Length; i++)
            {
                Console.Write(ar1[i] + " ");
            }
            Console.WriteLine("\nAfter Insert the element the new list is :");
            for (int i = 0; i < ar2.Length; i++)
            {
                Console.Write(ar2[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
