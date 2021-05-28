using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            if (IsAlphabetic(txt)) { Console.WriteLine("True"); } else { Console.WriteLine("False"); }
            Console.ReadLine();
        }
        static bool IsAlphabetic(string txt)
        {
            string s = txt.ToLower();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            int n = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(97 <= asciiBytes[i] && asciiBytes[i] <= 122)
                {
                    n++;
                }
            }
            if (n == s.Length) { return true; } else { return false; }           
        }
    }
}
