using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Gasoild = 0;
            int gas = Convert.ToInt32(Console.ReadLine());
            c.Refuel(gas);
            c.Drive();
            Console.ReadLine();
        }
    }
}
