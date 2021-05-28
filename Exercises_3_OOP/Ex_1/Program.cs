using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 3; i++)
            {
                Person a = new Person();
                a.Name = Console.ReadLine();
                Console.WriteLine(a.ToString());
            }
        }
    }
}
