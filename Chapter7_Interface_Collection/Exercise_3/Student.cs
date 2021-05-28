using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_3
{
    class Student : People
    {
        private double DotnetMark;
        private double JavaMark;

        public void InputDotnetMark()
        {
            while (true) {
                try
                {
                    Console.Write("DonetMark: ");
                    DotnetMark = Convert.ToDouble(Console.ReadLine());
                    if (0 > DotnetMark || 10 < DotnetMark)
                    {
                        Console.WriteLine("Dotnet mark is a number 0 to 10.");
                    }
                    else
                    {
                        break;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine("Please input float value.");
                }
            }
        }
        public void InputJavaMark()
        {
            while (true)
            {
                try
                {
                    Console.Write("JavaMark: ");
                    DotnetMark = Convert.ToDouble(Console.ReadLine());
                    if (0 > DotnetMark || 10 < DotnetMark)
                    {
                        Console.WriteLine("Java mark is a number 0 to 10.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input float value.");
                }
            }
        }

        public double GetAverageMark()
        {
            return (DotnetMark + JavaMark) / 2.0;
        }
        public override string TooString()
        {
            return base.TooString() + "\nAverageMark: "+ GetAverageMark();
        }
    }
}
