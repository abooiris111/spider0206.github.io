using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercises_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string phone="";
            InputPhone(phone);
            Console.WriteLine("Output:");
            Console.WriteLine(phone);
            Console.ReadLine();
        }
        static void InputPhone(string phone)
        {
            string pPhone = "(SE|HE)+([0-9]{6})";
            while (true)
            {
                Console.Write("Phone: ");
                phone = Console.ReadLine();
                Regex rg = new Regex(pPhone);
                if (rg.IsMatch(phone))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Number phone have 10 number.");
                }
            }
        }
    }
}
