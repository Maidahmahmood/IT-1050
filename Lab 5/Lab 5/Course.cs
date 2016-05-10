using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Course
    {
        private string _Name;
        private int _CRNNumber;
        private List<Student> _Students;
        public Course(string name, int crnNumber, List<Student> students)
        {
            _Name = name;
            _CRNNumber = crnNumber;
            _Students = students;
        }
        public string Name
        {
            get { return _Name; }
        }
        public int CRNNumber
        {
            get { return _CRNNumber; }
        }
        public List<Student> Students
        {
            get { return _Students; }
        }
        public string ProvideStudentsInformation()
        {
            string studentInfo = string.Empty;
            foreach(Student student in Students)
            {
                studentInfo += string.Format("Student Name is {0} and S number is {1}{2}", student.Name, student.SNumber, System.Environment.NewLine);
            }
            return studentInfo;
        }
        public string ProvideCourseInformation()
        {
            string courseInfo = string.Format("Course {0} with course number {1} has been added.{2}There are {3} students enrolled in this course.",
                    this.Name, this.CRNNumber, System.Environment.NewLine, this.Students.Count);
            return courseInfo;
        }
    }
}
