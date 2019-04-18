using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles did you drive today?");
            double miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many stops did you make today?");
            double stops = Convert.ToInt32(Console.ReadLine());

            double todaysPay = (miles * 0.48) + stops * 18.50;

            Console.WriteLine("You made ${0} today!", todaysPay);
            Console.ReadLine();
        }
    }
}
