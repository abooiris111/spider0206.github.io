using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Dog : Animail, IEat, IDrink
    {
        public void Drink()
        {
            Console.WriteLine("Dog can drink.");
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Next()
        {
            throw new NotImplementedException();
        }

        public override void Velocity()
        {
            throw new NotImplementedException();
        }
    }
}
