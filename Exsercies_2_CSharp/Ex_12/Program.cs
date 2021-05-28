using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listC = new List<Car>();
            for(int i = 1; i <= 3; i++)
            {
                string model = Console.ReadLine();
                int year = Convert.ToInt32(Console.ReadLine());
                listC.Add(new Car() { Model = model, Year = year });
            }
            var carListSortByYear = listC.OrderBy(C => C.Year);
            foreach(Car o in carListSortByYear)
            {
                o.GetInfo();
            }
            Console.ReadLine();
        }
    }
}
