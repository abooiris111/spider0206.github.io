using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session5_OOPinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khoi tao doi tuong kieu class la Manager
            Manager m1 = new Manager(1, "David", 30, 1);
            Console.WriteLine(m1.DisplayInfo());
            Manager m2 = new Manager();
            m2.InputInfo(2, "Tom", 35);
            m2.Department = 5;
            Console.WriteLine(m2.DisplayInfo());
            Console.ReadLine();
        }
    }
}
