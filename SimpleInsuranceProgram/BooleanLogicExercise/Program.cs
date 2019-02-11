using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageOne = Convert.ToInt32(age);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            bool dui = Boolean.Parse("true");
            bool noDui = Boolean.Parse("false");
            Console.ReadLine();


            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(tickets);
            Console.ReadLine();

            if (ageOne >= 15 && noDui && speedingTickets >= 3)
            {
                Console.WriteLine("You are qualified");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("You are not qualified");
                Console.ReadLine();
            }
        }
    }
}
