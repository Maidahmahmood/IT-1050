using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("You are creating a course. Press any key to continue...");
            System.Console.ReadKey();
            bool IsCourseCreated = false;
            while (!IsCourseCreated)
            {
                System.Console.WriteLine("Enter the course name");
                string courseName = System.Console.ReadLine();
                System.Console.WriteLine("Enter course number");
                int courseNumber = GetIntegerReply();
                System.Console.WriteLine("How many students are taking  the course");
                int numberOfStudentsInCourse = GetIntegerReply();
                List<Student> students = CreateStudents(numberOfStudentsInCourse);
                Course newCourse = new Course(courseName, courseNumber, students);
                System.Console.WriteLine(System.Environment.NewLine);
                System.Console.WriteLine(newCourse.ProvideCourseInformation());
                System.Console.WriteLine("Here is information of students enrolled in the class:");
                System.Console.WriteLine(newCourse.ProvideStudentsInformation());

                System.Console.WriteLine("Does all information look good? Press Y to exit and N to start over");
                string reviewAnswer = System.Console.ReadLine();
                while (!reviewAnswer.Equals("Y", StringComparison.OrdinalIgnoreCase)
                    && !reviewAnswer.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine("Invalid answer. Try again.");
                    reviewAnswer = System.Console.ReadLine();
                }
                if (reviewAnswer.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    IsCourseCreated = true;
            }
        }

        private static int GetIntegerReply()
        {
            int result;
            string reply = System.Console.ReadLine();
            while (!Int32.TryParse(reply, out result))
            {
                System.Console.WriteLine("Invalid answer. Try again.");
                reply = System.Console.ReadLine();
            }
            return result;
        }
        private static List<Student> CreateStudents(int numberOfStudents)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfStudents; ++i)
            {
                System.Console.WriteLine(string.Format("Student {0}: Enter student name", i+1));
                string name = System.Console.ReadLine();
                System.Console.WriteLine(string.Format("Student {0}: Enter student's S number", i+1));
                int sNumber = GetIntegerReply();

                students.Add(new Student(name, sNumber));
            }
            return students;
        }
       
    }
}
