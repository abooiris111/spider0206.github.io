using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_2
{
    class MyCollection<T>
    {
        ArrayList list = new ArrayList();
        public void Add(T obj)
        {
            list.Add(obj);
        }
        public void Add(T obj, int k)
        {
            list.Insert(k, obj);
        }
        public void DisplayItems()
        {
            Console.WriteLine("Items in my collection: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
