using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment() { amount = 1000 };
            payment.AmountChanged += notifyAmountChanged;
            payment.Amount = 990;

            Console.WriteLine("Tax: " + payment.ComputeTax());
            Console.ReadLine();
        }
        public static void notifyAmountChanged(float oldValue, float newValue)
        {
            Console.WriteLine("Amount changed – old value: "+oldValue+", new value : " + newValue);
        }
    }
}
