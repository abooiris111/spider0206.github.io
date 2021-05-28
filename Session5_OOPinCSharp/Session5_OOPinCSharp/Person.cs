using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session5_OOPinCSharp
{
    class Person : IHuman
    {
        // Data field
        private int id;
        private string name;
        private int age;

        //Encapsulate: Thuc hien dong goi cho cac data field
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; }

        //Phuong thuc nay cho lop con ghi de lai
        public virtual string DisplayInfo()
        {
            return "Id: " + this.id + "\nName: "+this.name+"\nAge: "+this.age;
        }

        //Phuong thuc nap chong la phuong thuc co cung: Ten, Keu du lieu tra ve
        //Nam trong cung 1 class
        //Khac nhau: So luong tham so hoac kieu du lieu cua tham so(neu cung so luong)
        public void InputInfo(string id, string name, int age)
        {

        }

        public void InputInfo(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void InputInfo(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Person() { }

        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }
}
