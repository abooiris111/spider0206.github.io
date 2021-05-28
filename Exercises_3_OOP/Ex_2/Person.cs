using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_2
{
    class Person
    {
        protected int n;
        public void Greet() 
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            n = age;
        }
    }
}
