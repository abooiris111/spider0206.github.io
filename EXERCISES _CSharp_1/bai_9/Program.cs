using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Fpt@university";
            string t1 = text.Substring(1,text.Length-1);
            string t2 = text.Remove(3,1);
            string t3 = text.Substring(0, text.Length - 1);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.ReadLine();
        }
    }
}
