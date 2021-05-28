using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_4
{
     abstract class Animal
     {
        private string Name;

        public void SetName(string name)
        {
            Name = name;
        }
        public void GetName()
        {
            Console.WriteLine(Name);
        }
         public abstract void Eat();
     }
}
