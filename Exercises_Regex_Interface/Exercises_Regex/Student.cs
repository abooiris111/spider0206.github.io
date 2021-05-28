using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercises_Regex
{
    class Student
    {
        public string Roll;
        public string Name;
        public string Email;
        public string Phone;
        public void InputInfor(string roll, string name, string email, string phone)
        {
            string parRoll = "(SE|HE)+([0-9]{6})";
            string parName = "[a-zA-Z ]";
            while (true)
            {
                Console.Write("Roll: ");
                roll = Console.ReadLine();
                Regex rg = new Regex(@"^(SE|HE)+([0-9]{6})$");
                if (rg.IsMatch(roll))
                {
                    Roll = roll;
                    break;
                }
                else
                {
                    Console.WriteLine("Roll is HE or SE and 6 numbers.");
                }
            }
            while (true)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                Regex rg = new Regex(@"^[a-zA-Z\s]$");
                if (rg.IsMatch(name))
                {
                    Name = name;
                    break;
                }
                else
                {
                    Console.WriteLine("Name don't have number anh special.");
                }
            }
            while (true)
            {
                Console.Write("Roll: ");
                roll = Console.ReadLine();
                Regex rg = new Regex(@"^\w[\.]@\w\.[a-z]{3}\.[a-z]{2}$");
                if (rg.IsMatch(roll))
                {
                    Roll = roll;
                    break;
                }
                else
                {
                    Console.WriteLine("Number phone have 10 number.");
                }
            }
            while (true)
            {
                Console.Write("Roll: ");
                roll = Console.ReadLine();
                Regex rg = new Regex(@"^[0-9]{10}$");
                if (rg.IsMatch(roll))
                {
                    Roll = roll;
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
