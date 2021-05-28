using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input " + n + " number of elements in the array : ");
            int[] ar = new int[n];
            for (int i = 0; i<ar.Length;i++)
            {
                Console.Write("element-"+i+":");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i]+" ");
            }
            Console.WriteLine("\nThe values store into the array in reverse are :");
            for (int i = ar.Length-1; i >= 0; i--)
            {
                Console.Write(ar[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
