using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime);
            Console.WriteLine("Enter a number");
            int usersNumber = Convert.ToInt32(Console.ReadLine());
            DateTime combined = dateTime.AddHours(usersNumber);

            Console.WriteLine("You entered {0} it will be {1} in {0} hours", usersNumber, combined);
            Console.ReadLine();
        }
    }
}
