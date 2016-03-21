using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;

        public string GetFullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine("Name: " + GetFullName() + "  Age: " + Age);
        }

    }
}
