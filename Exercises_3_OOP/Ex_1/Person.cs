using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_1
{
    public class Person
    {
        private string name;


        public Person()
        {
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
}
