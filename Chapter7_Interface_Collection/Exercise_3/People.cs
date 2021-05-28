using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_3
{
    class People
    {
        private int ID;
        private string Name;
        private int Age;

        public void InputID()
        {
            while (true)
            {
                try
                {
                    Console.Write("ID: ");
                    ID = Convert.ToInt32(Console.ReadLine());
                    if (0 > ID)
                    {
                        Console.WriteLine("ID is a integer value and bigger than 0.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input int value.");
                }
            }
        }
        public void InputName()
        {
            while (true)
            {
                try
                {
                    Console.Write("Name: ");
                    Name = Console.ReadLine();
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input string value.");
                }
            }
        }
        public void InputAge()
        {
            while (true)
            {
                try
                {
                    Console.Write("Age: ");
                    Age = Convert.ToInt32(Console.ReadLine());
                    if (1 > Age)
                    {
                        Console.WriteLine("Age is a integer value and bigger than 1.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input int value.");
                }
            }
        }
        public virtual string TooString()
        {
            return "ID: " + ID + "\nName: " + Name + "\nAge: " + Age;
        }
    }
}
