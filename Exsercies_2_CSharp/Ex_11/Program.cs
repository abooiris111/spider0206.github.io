using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ChangeLetter(txt, index));
            Console.ReadLine();
        }
        static string ChangeLetter(string txt, int index)
        {
            //return txt.Substring(0, index) + txt.Substring(index + 1);
            return txt.Remove(index, 1);
        }
    }
}
