using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {

        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            bool p1Married;
            bool p2Married;

            System.Console.WriteLine("Enter first person's information");
            System.Console.WriteLine("What is the first name?");
            p1.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is the last name?");
            p1.LastName = System.Console.ReadLine();
            System.Console.WriteLine("What is the Age?");
            p1.Age = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Is this person married?");
            p1Married = Convert.ToBoolean(System.Console.ReadLine());
            System.Console.WriteLine("What is the first name of spouse?");
            p1.Spouse = new Person();
            Person.SumOfAllAges = p1.Age;
            p1.Spouse.FirstName = System.Console.ReadLine();
            p1.Spouse.LastName = p1.LastName;
            System.Console.WriteLine("What is the Age of spouse?");
            p1.Spouse.Age = Convert.ToInt32(System.Console.ReadLine());
            Person.SumOfAllAges = Person.SumOfAllAges + p1.Spouse.Age;

            System.Console.WriteLine("Enter second person's information");
            System.Console.WriteLine("What is the first name?");
            p2.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is the last name?");
            p2.LastName = System.Console.ReadLine();
            System.Console.WriteLine("What is the Age?");
            p2.Age = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Is this person married?");
            p2Married = Convert.ToBoolean(System.Console.ReadLine());
            System.Console.WriteLine("What is the first name of spouse?");
            p2.Spouse = new Person();
            Person.SumOfAllAges = Person.SumOfAllAges + p2.Age;
            p2.Spouse.FirstName = System.Console.ReadLine();
            p2.Spouse.LastName = p2.LastName;
            System.Console.WriteLine("What is the Age of spouse?");
            p2.Spouse.Age = Convert.ToInt32(System.Console.ReadLine());
            Person.SumOfAllAges = Person.SumOfAllAges + p2.Spouse.Age;

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();
            System.Console.WriteLine("Average Age: " + Person.SumOfAllAges / 4);
            System.Console.WriteLine("Press any key to exit");
            System.Console.Read();
        }
    }
}
