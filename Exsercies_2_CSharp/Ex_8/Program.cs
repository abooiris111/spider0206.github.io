using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            for(int i = 0; i < n; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool match = false;
            while (true)
            {
                int val = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    if (ar[i] == val)
                    {
                        Console.WriteLine("The number " + val + " exist");
                        match = true;
                        break;
                    }
                }
                if (match == true) { Console.ReadLine(); break; }
                if (match == false)
                {
                    Console.WriteLine("The number " + val + " not exist");
                }
            }
        }
    }
}
