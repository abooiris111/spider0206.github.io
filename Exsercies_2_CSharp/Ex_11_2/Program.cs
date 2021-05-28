using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 3;
            //Car car = new Car();
            //car.Model = Console.ReadLine();
            //car.AnyoFabricacion1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(car);
            Carr[] cars = new Carr[max];


            // nhap du lieu Object Car
            for (int i = 0; i < max; i++)
            {
                cars[i] = new Carr()
                {
                    model = Console.ReadLine(),
                    year = Convert.ToInt32(Console.ReadLine())

                };
            }

            // Sort - sap xep
            for (int i = 0; i < max; i++)
            {
                for (int j = i + 1; j < max; j++)
                {
                    if (cars[i].year > cars[j].year)
                    {
                        var temp = cars[i];
                        cars[i] = cars[j];
                        cars[j] = temp;
                    }
                }
            }

            //show
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Model: " + cars[i].model +
                    ", Year of production: " + cars[i].year);

            }
            Console.ReadLine();

        }
        struct Carr
        {
            public string model;
            public int year;
        }
    }
}
