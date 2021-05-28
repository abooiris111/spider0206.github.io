using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Display the pattern like pyramid using the alphabet.";
            string[] t = text.Split();
            string rev = "";
            for (int i = t.Length-1 ; i > 0 ; i--)
            {
                rev = rev + t[i] + " ";
            }
            rev = rev + t[0];
            Console.WriteLine("Original String: " + text);
            Console.WriteLine("Reverse String: " + rev);
            Console.ReadLine();
        }
    }
}
