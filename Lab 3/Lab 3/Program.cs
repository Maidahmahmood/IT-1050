using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("John", "", "English");
            Instructor mike = new Instructor("Mike", "", "Math");

            Student jane = new Student("Jane", john);
            Student joe = new Student("Joe", john);
            Student melissa = new Student("Melissa", mike);
            Student matt = new Student("Matt", mike);

            john.SetStudntGrade(jane, 95);
            john.SetStudntGrade(joe, 85);
            mike.SetStudntGrade(melissa, 90);
            mike.SetStudntGrade(matt, 92);

            jane.Print();
            joe.Print();
            melissa.Print();
            matt.Print();
            System.Console.WriteLine("Press any key to exit");
            System.Console.Read();

        }
    }
}
