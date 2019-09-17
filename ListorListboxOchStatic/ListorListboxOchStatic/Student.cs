using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListorListboxOchStatic
{
    class Student
    {
        public static List<Student> studentList = new List<Student>();

        public string _firstname;


        public Student(string firstname)
        {
            this._firstname = firstname;
        }

        public override string ToString()
        {
            return "Namn: " + this._firstname;
        }

        public static void addStudent(Student s)
        {
            studentList.Add(s);
        }

    }
}
