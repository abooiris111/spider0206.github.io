using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kieu Collection (non-Generic)
            // ArrayList (index), SortedList(index, key-value)
            // Khoi tao 1 collection co kieu ArrayKist
            IList list1 = new ArrayList();

            ICollection list2 = new ArrayList();
            IEnumerable list3 = new ArrayList();
            ArrayList list4 = new ArrayList();

            // Them phan tu vao trong list1
            list4.Add(5);
            list4.Add(true);
            list4.Add(10.7);

            ArrayList list5 = new ArrayList() { "Hello", 2.6f };
            list4.AddRange(list5);

            list4.Insert(1, "C#");

            //Hien thi cac phan tu trong list4
            for(int i=0; i < list4.Count; i++)
            {
                Console.WriteLine("list[" + i + "] = " + list4[i]);
            }
            Console.ReadLine();
        }
    }
}
