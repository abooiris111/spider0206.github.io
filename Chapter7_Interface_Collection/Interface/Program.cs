using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // The hien doi tuong Cat
            IEat canEat1 = new Cat();
            IEat canEat2 = new Dog();

            //Tinh da hinh the hien ro nhat o day
            // C# luon biet ro kieu thuc te cua 1 doi tuong

            canEat1.Eat();

            //Kiem tra doi tuong 'canEat1' co phai con meo hay ko
            bool isCat = canEat1 is Cat;
            Console.WriteLine("canEat1 is Cat? " + isCat);

            if(canEat2 is Dog)
            {
                Dog dog = (Dog) canEat2;
                dog.Drink();
            }
            Console.ReadLine();
        }
    }
}
