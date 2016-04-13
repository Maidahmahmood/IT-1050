using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {

        private static double[] MatineePrices = new double[] { 3.99, 5.99, 4.50 };
        private static double[] EveningPrices = new double[] { 6.99, 10.99, 8.50 };
        private static double[] ConcessionStand = new double[] { 3.50, 5.99, 3.99, 4.5, 1.99 };
        private static int[] NumberOfItems = new int[] { 0, 0, 0, 0, 0 };

        static void Main(string[] args)
        {

            const int CHILD = 0;
            const int ADULT = 1;
            const int SENIOR = 2;
            double cost = 0;
            double discount = 0;
            string time = string.Empty;

            while (!time.Equals("day", StringComparison.OrdinalIgnoreCase) && !time.Equals("evening", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("What time do you want to for the movie?");
                Console.WriteLine("Enter 'Day' or 'Evening'");
                time = Console.ReadLine();
            }

            int childTickets = -1;
            while (childTickets.Equals(-1))
            {
                Console.WriteLine("How many child tickets do you need?");
                childTickets = Convert.ToInt32(Console.ReadLine());
            }

            int adultTickets = -1;
            while (adultTickets.Equals(-1))
            {
                Console.WriteLine("How many adult tickets do you need?");
                adultTickets = Convert.ToInt32(Console.ReadLine());
            }

            int seniorTickets = -1;
            while (seniorTickets.Equals(-1))
            {
                Console.WriteLine("How many senior tickets do you need?");
                seniorTickets = Convert.ToInt32(Console.ReadLine());
            }

            AskConsessionStandChoice(ConcessionStand.Length - 1);
            cost = CalculateTotalCost(time, childTickets, adultTickets, seniorTickets);
            Console.WriteLine("Total cost is " + cost);
            Console.ReadKey();

        }

        private static void AskConsessionStandChoice(int totalChoices)
        {
            string answer = string.Empty;
            while (!answer.Equals("x", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("What do you want to buy from the Concession stand?");
                Console.WriteLine("Enter 0 for Small Soda");
                Console.WriteLine("Enter 1 for Large Soda");
                Console.WriteLine("Enter 2 for Hot Dog");
                Console.WriteLine("Enter 3 for Popcorn");
                Console.WriteLine("Enter 4 for Candy");
                Console.WriteLine("Enter X to if you are done");
                answer = Console.ReadLine();
                if (!answer.Equals("x", StringComparison.OrdinalIgnoreCase))
                {
                    int concessionStandSelection = Convert.ToInt32(answer);
                    NumberOfItems[concessionStandSelection] = AskNumberOfItemsFromConcessionStand();
                }
                else
                    break;
            }
        }

        private static int AskNumberOfItemsFromConcessionStand()
        {
            int number = -1;
            while (number < 0)
            {
                Console.WriteLine("How many do you want to buy?");
                number = Convert.ToInt32(Console.ReadLine());
            }
            return number;
        }

        private static double CalculatePopcornSodaDiscount(int totalTickets)
        {
            if (NumberOfItems[1] > NumberOfItems[3])
            {
                if (NumberOfItems[1] > totalTickets)
                    return totalTickets * 2;
                else
                    return NumberOfItems[1] * 2;
            }
            else
            {
                if (NumberOfItems[3] > totalTickets)
                    return totalTickets * 2;
                else
                    return NumberOfItems[3] * 2;
            }
        }

        private static double CalculateTotalCost(string timeOfDay, int childTickets, int adultTickets, int seniorTickets)
        {
            double movieCost = CalculateItemsCost();
            int totalTickets = childTickets + adultTickets + seniorTickets;
            double discount = CalculatePopcornSodaDiscount(totalTickets);
            
            if(timeOfDay.Equals("day", StringComparison.OrdinalIgnoreCase))
            {
                movieCost += (MatineePrices[0] * childTickets) + (MatineePrices[1] * adultTickets) + (MatineePrices[2] * seniorTickets);
            }
            else
            {
                if(totalTickets > 2)
                {
                    NumberOfItems[3] = NumberOfItems[3] + 1;
                }
                movieCost = (EveningPrices[0] * childTickets) + (EveningPrices[1] * adultTickets) + (EveningPrices[2] * seniorTickets);
            }
            return movieCost - discount;
        }

        private static double CalculateItemsCost()
        {
            double itemCost = 0;
            int numberOfThree = NumberOfItems[4] / 3;
            itemCost = (NumberOfItems[4] - numberOfThree) * ConcessionStand[4];
            itemCost += (NumberOfItems[0] * ConcessionStand[0]);
            itemCost += (NumberOfItems[1] * ConcessionStand[1]);
            itemCost += (NumberOfItems[2] * ConcessionStand[2]);
            itemCost += (NumberOfItems[3] * ConcessionStand[3]);
            return itemCost;
        }
    }
}
