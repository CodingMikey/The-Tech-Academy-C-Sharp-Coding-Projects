using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyStudentReports
{
    class Program
    {
        static void Main(string[] args)
        {
            string rows = "The Tech Academy\r\nStudent Daily Report\r\nPress Enter to Begin";
            Console.WriteLine(rows);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.ReadLine();

            
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int number = Convert.ToInt32(pageNumber);
            Console.ReadLine();

            
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool needHelp = Boolean.Parse("true");
            bool noHelp = Boolean.Parse("false");
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyTime = Console.ReadLine();
            int study = Convert.ToInt32(studyTime);
            Console.ReadLine();

            string endMessage = "Thank you for your answers. An Instructor will respond to this shortly. Have a great day!";
            Console.WriteLine(endMessage);
            Console.ReadLine();


        }
    }
}
