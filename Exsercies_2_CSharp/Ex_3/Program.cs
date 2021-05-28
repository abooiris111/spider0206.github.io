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
            while (true)
            {
                string user = Console.ReadLine();
                string pass = Console.ReadLine();
                if (user.Equals("12") && pass.Equals("1234"))
                {
                    Console.WriteLine("Login successfull");
                    break;
                }
                else
                {
                    Console.WriteLine("Login failed");
                }
            }
        }
    }
}
