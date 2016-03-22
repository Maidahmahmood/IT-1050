using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Instructor
    {
        private string firstName;
        private string lastName;
        private string Coursename;

        public Instructor(string Firstname, string Lastname,string coursename)
        {
            firstName = Firstname;
            lastName = Lastname;
            Coursename = coursename;
        }

        public void SetStudntGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

       public void Print()
        {
            System.Console.WriteLine(firstName + " " + lastName + " " + Coursename);
        }




    }
}
