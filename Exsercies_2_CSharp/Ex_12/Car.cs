using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_12
{
    class Car
    {
        private string model;
        private int year;

        public Car()
        {
        }

        public Car(string model, int year)
        {
            this.model = model;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }

        public void GetInfo()
        {
            Console.WriteLine("Model: {0}, Year of production: {1}", model, year);
        }
    }
}
