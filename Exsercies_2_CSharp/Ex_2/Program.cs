﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 500; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
