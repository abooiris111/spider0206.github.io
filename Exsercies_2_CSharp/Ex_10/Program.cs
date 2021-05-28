using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ar = new int[2,10];
            double gr1 = 0;
            double gr2 = 0;
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    ar[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0) { gr1 = gr1 + ar[i,j]; }
                    if (i == 1) { gr2 = gr2 + ar[i,j]; }
                }
            }
            Console.WriteLine("Average for group 1 is " + gr1 / 10.0);
            Console.WriteLine("Average for group 2 is " + gr2 / 10.0);
            Console.ReadLine();
        }
    }
}
