using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    //Abstract: Chua ro rang
    abstract class Animail : IMove
    {
        public void Back()
        {
            Console.WriteLine("Back ... ");
        }

        public abstract void Next();

        public abstract void Velocity();
    }
}
