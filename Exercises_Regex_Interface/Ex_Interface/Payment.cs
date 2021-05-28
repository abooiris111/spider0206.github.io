using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Interface
{
    public class Payment : ITax
    {
        // khai bao 1 delegate: ham con tro se tham chieu cho Event
        public delegate void Notify(float oldValue, float newValue);

        // Khai bao 1 event
        public event Notify AmountChanged;


        public float amount;
        public float Amount
        {
            get { return amount; }
            set
            {
                if(value != amount)
                {
                    if (AmountChanged != null) //Khi Event dc goi trong main
                        AmountChanged(amount, value);// thay doi gia tri moi
                    amount = value;
                }
            }
        }
        public float ComputeTax()
        {
            float tax = (Amount * 10) / 100;
            return tax;
        }
    }
}
