using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            if (IsNumber(txt)) { Console.WriteLine("True"); } else { Console.WriteLine("False"); }
            Console.ReadLine();
        }
        static bool IsNumber(string s)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            int n = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (48 <= asciiBytes[i] && asciiBytes[i] <= 57)
                {
                    n++;
                }
            }
            if (n == s.Length) { return true; } else { return false; }
        }
    }
}
