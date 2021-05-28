using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Python";
            Console.WriteLine(Program.Swapp(text));
            Console.ReadLine();
        }

        static string Swapp(string txt)
        {
            string t = txt;
            t = t.Remove(0, 1);
            t = t.Remove(t.Length-1, 1);
            t = t.Insert(0, txt.Substring(txt.Length-1,1));
            t = t.Insert(t.Length, txt.Substring(0, 1));
            return t;
        }
    }
}
