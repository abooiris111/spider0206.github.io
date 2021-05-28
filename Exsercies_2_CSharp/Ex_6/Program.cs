using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            for(int i = 0; i < 5; i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0, max = n[1], min = n[1];
            for (int i = 0; i < 5; i++)
            {
                sum = sum + n[i];
                if (n[i] > max) { max = n[i]; }
                if (n[i] < min) { min = n[i]; }
            }
            Console.WriteLine("Suma: " +sum);
            Console.WriteLine("Media: " + sum/5);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.ReadLine();
        }
    }
}
