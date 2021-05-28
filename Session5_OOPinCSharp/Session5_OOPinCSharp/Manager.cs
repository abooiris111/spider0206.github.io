using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session5_OOPinCSharp
{
    class Manager : Person
    {
        //Thuoc tinh moi 
        private int department;

        public int Department { get => department; set => department = value; }

        public bool Approve()
        {
            //Kiem tra qua trinh phe duyet
            return true;
        }

        //Tao contructor trong class Manager
        public Manager() : base() { }

        public Manager(int id, string name, int age, int dept) : base(id, name, age)
        {
            this.department = dept;
        }

        //Thuc hien ghi de tai phuong thuc DisplayInfo cua lop cha
        public override string DisplayInfo()
        {
            return base.DisplayInfo() + "\nDepartment: " + this.department;
        }
    }
}
