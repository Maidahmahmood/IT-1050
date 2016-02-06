using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            System.Console.WriteLine("what is your first name");
            firstName = System.Console.ReadLine();
            System.Console.WriteLine("what is your middle initial");
            middleInitial = System.Console.ReadLine();
            System.Console.WriteLine("what is your last name");
            lastName = System.Console.ReadLine();
            fullName = firstName + " " + middleInitial + " " + lastName;
            System.Console.WriteLine("what is your height in feet 4,5 or 6");
            heightFeet = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("how many inches do you add in your base height in feet");
            heightInches = Convert.ToDouble(System.Console.ReadLine());
            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;
            System.Console.WriteLine("what is your age");
            age = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("are you a citizen");
            isCitizen = Convert.ToBoolean(System.Console.ReadLine());
            canVote = isCitizen && (age > 17);
            System.Console.WriteLine(fullName);
            System.Console.WriteLine(totalHeightCM);
            System.Console.WriteLine(canVote);
            ;










}
    }
}
