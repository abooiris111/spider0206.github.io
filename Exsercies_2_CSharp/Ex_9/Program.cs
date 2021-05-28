using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int pos = 0, neg = 0, numPos = 0;
            for (int i = 0; i < 10; i++)
            {
                if (ar[i] > 0)
                {
                    pos = pos + ar[i];
                    numPos++;
                }
                if(ar[i] < 0)
                {
                    neg = neg + ar[i];
                }
            }
            Console.WriteLine("Average numbers negatives is " + neg / (10 - numPos));
            Console.WriteLine("Average numbers positives is " + pos / numPos);
            Console.ReadLine();
        }
    }
}
