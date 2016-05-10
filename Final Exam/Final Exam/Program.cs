using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Program
    {
        public static void Main(string[] args)
        {
            Elevator elevator1;
            elevator1 = new Elevator(2, 400);
            elevator1.AddOccupant(new Passenger("A1", 180), 0);
            elevator1.AddOccupant(new Passenger("A2", 220), 1);
            bool elevator1IsOverMaxCapacity;
            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            Elevator elevator2;
            elevator2 = new Elevator(3, 600);
            elevator2.AddOccupant(new Passenger("A1", 200), 0);
            elevator2.AddOccupant(new Passenger("A2", 200), 1);
            elevator2.AddOccupant(new Passenger("A3", 201), 2);
            bool elevator2IsOverMaxCapacity;
            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
        }
    }
}
