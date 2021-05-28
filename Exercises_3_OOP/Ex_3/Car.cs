using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_3
{
    class Car : IVehiculo
    {
        private int gasoild;

        public Car()
        {
        }

        public Car(int gasoild)
        {
            this.gasoild = gasoild;
        }

        public int Gasoild { get => gasoild; set => gasoild = value; }

        public void Drive()
        {
            if (gasoild > 0)
            {
                Console.WriteLine("Driving");
            }
        }

        public bool Refuel(int gasoline)
        {
            gasoild = gasoild + gasoline;
            return true;
        }
    }
}
