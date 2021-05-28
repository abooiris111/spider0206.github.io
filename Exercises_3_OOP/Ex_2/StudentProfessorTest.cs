using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_2
{
    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            a.Greet();
            Student st = new Student();
            st.SetAge(21);
            st.Greet();
            st.ShowAge();
            st.Study();
            Teacher t = new Teacher();
            t.SetAge(30);
            t.Greet();
            t.Explain();
            Console.ReadLine();
        }
    }
}
