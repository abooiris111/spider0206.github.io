using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_HE141466_ThanhCV
{
    class Program
    {
        static int[] ar = new int[1000];
        static int index = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                Console.Write("Enter a option(1-5): ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: 
                        Add();
                        break;
                    case 2:
                        Show();
                        break;
                    case 3:
                        Search();
                        break;
                    case 4:
                        Statistics();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Show");
            Console.WriteLine("3. Search");
            Console.WriteLine("4. Statistics");
            Console.WriteLine("5. Exit");
        }
        static void Add()
        {
            int value = Convert.ToInt32(Console.ReadLine());
            ar.SetValue(value, index);
            index++;
        }
        static void Show()
        {
            for(int i = 0; i < index; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
        static void Search()
        {
            bool checkSearch = false;
            int search = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                if (search == ar[i])
                {
                    Console.WriteLine("Found " + search + " at index " + i + " in array");
                    checkSearch = true;
                }
            }
            if (checkSearch == false)
            {
                Console.WriteLine("Not found");
            }
        }
        static void Statistics()
        {
            int sum = 0, ave = 0, min = ar[0], max = ar[0];
            for(int i = 0; i < index; i++)
            {
                sum = sum + ar[i];
                if (ar[i] > max) { max = ar[i]; }
                if (ar[i] < min) { min = ar[i]; }
            }
            Console.WriteLine("Sum: "+sum);
            Console.WriteLine("Average: " + sum/index);
            Console.WriteLine("Min value: " + min);
            Console.WriteLine("Max value: " + max);
        }
    }
}
