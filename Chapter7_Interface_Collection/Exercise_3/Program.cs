using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listS = new ArrayList();
            Student st1 = new Student();
            Console.WriteLine("Student 1: ");
            st1.InputID();
            st1.InputName();
            st1.InputAge();
            st1.InputDotnetMark();
            st1.InputJavaMark();
            listS.Add(st1);
            Student st2 = new Student();
            Console.WriteLine("Student 2: ");
            st2.InputID();
            st2.InputName();
            st2.InputAge();
            st2.InputDotnetMark();
            st2.InputJavaMark();
            listS.Add(st2);
            ArrayList listV = new ArrayList();
            Teacher t1 = new Teacher();
            Console.WriteLine("Teacher 1: ");
            t1.InputID();
            t1.InputName();
            t1.InputAge();
            t1.InputClassNumber();
            t1.InputSubjectNumber();
            listV.Add(t1);
            Teacher t2 = new Teacher();
            Console.WriteLine("Teacher 2: ");
            t2.InputID();
            t2.InputName();
            t2.InputAge();
            t2.InputClassNumber();
            t2.InputSubjectNumber();
            listV.Add(t2);
            foreach(Student st in listS)
            {
                Console.WriteLine(st.TooString());
            }
            foreach (Teacher t in listV)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine(t.TooString());
                Console.WriteLine("-----------------");
            }
            Console.ReadLine();
        }
    }
}
