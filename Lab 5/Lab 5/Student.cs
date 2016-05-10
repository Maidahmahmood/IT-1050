using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Student
    {
        private string _Name;
        private int _SNumber;

        public Student(string name, int sNumber)
        {
            _Name = name;
            _SNumber = sNumber;
        }
        public Student(int sNumber)
        {
            sNumber = _SNumber;
        }
        public string Name
        {
            get { return _Name; }
        }
        public int SNumber
        {
            get { return _SNumber; }
        }
    }
}
