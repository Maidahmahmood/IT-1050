using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        private string name;
        private int grade;
        private Instructor teacher;

        public Student(string studentName, Instructor instructor)
        {
            name = studentName;
            teacher = instructor;
            grade = 0;
        }

        public void SetGrade(int studentGrade)
        {
            grade = studentGrade;
        }
        public void Print()
        {

            System.Console.WriteLine(name + " " + grade + " ");
            teacher.Print();

        }





       }
}
