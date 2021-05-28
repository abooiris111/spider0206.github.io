using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            Dog a = new Dog();
            a.SetName(name);
            a.GetName();
            a.Eat();
            Console.ReadLine();
        }
    }
}
