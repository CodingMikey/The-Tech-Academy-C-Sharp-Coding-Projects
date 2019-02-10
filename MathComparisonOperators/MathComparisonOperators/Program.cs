using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Anonymous Income Comparison Program";
            Console.WriteLine(greeting);
            Console.ReadLine();

            Console.WriteLine("Person1");
            Console.ReadLine();

            Console.WriteLine("What is your hourly rate?");
            string payRate = Console.ReadLine();
            decimal payRate1 = Convert.ToInt32(payRate);
            Console.WriteLine(payRate1);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string hours = Console.ReadLine();
            decimal hours1 = Convert.ToInt32(hours);
            Console.WriteLine(hours1);
            Console.ReadLine();

            Console.WriteLine("Person2");
            Console.ReadLine();

            Console.WriteLine("What is your hourly rate?");
            string payRate2 = Console.ReadLine();
            decimal payRate22 = Convert.ToInt32(payRate2);
            Console.WriteLine(payRate22);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();
            decimal hours22 = Convert.ToInt32(hours2);
            Console.WriteLine(hours22);
            Console.ReadLine();

            decimal salaryOne = payRate1 * hours1;
            Console.WriteLine("Weekly salary of person 1 is " + salaryOne);
            Console.ReadLine();

            decimal salaryTwo = payRate22 * hours22;
            Console.WriteLine("Weekly salary of person 2 is " + salaryTwo);
            Console.ReadLine();

            bool greaterThan = salaryOne > salaryTwo;
            Console.WriteLine("Person 1 makes more than Person 2: " + greaterThan);
            Console.ReadLine();
        }
    }
}
