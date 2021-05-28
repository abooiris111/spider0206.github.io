using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] t = text.Split();
            string longestTxt = t[0];
            for(int i=1;i<t.Length;i++)
            {
                if (longestTxt.Length<t[i].Length)
                {
                    longestTxt = t[i];
                }
            }
            Console.WriteLine(longestTxt);
            Console.ReadLine();
        }
    }
}
