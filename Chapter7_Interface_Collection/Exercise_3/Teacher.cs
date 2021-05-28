using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_3
{
    class Teacher : People
    {
        private int ClassNumber;
        private int SubjectNumber;
        public void InputClassNumber()
        {
            while (true)
            {
                try
                {
                    Console.Write("Class Number: ");
                    ClassNumber = Convert.ToInt32(Console.ReadLine());
                    if (0 > ClassNumber)
                    {
                        Console.WriteLine("ClassNumber is a integer value and bigger than 0.");
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
        public void InputSubjectNumber()
        {
            while (true)
            {
                try
                {
                    Console.Write("SubjectNumber: ");
                    SubjectNumber = Convert.ToInt32(Console.ReadLine());
                    if (0 > SubjectNumber)
                    {
                        Console.WriteLine("SubjectNumber is a integer value and bigger than 0.");
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
        public int GetTotalSubject()
        {
            return ClassNumber * SubjectNumber;
        }

        public override string TooString()
        {
            return base.TooString() + "\nTotal Subject: " + GetTotalSubject();
        }
    }
}
