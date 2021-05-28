using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Cat : Animail, IEat, IDrink
    {
        public void Drink()
        {
            Console.WriteLine("Cat can drink.");
        }

        public void Eat()
        {
            Console.WriteLine("Cat can eat.");
        }

        public override void Next()
        {
            Console.WriteLine("Cat can next.");
        }

        public override void Velocity()
        {
            Console.WriteLine("10km/h");
        }
    }
}
