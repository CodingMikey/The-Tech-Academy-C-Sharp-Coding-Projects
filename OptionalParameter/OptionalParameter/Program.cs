using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            Console.WriteLine("Enter two numbers, one at a time. The second number is optional");
            int usersInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number or enter zero");
            int usersInputTwo = Convert.ToInt32(Console.ReadLine());

            int oneNumber = numbers.numbersClass(usersInput);
            int twoNumbers = numbers.numbersClass(usersInput, usersInputTwo);

            if (usersInputTwo == 0)
            {
                Console.WriteLine(oneNumber);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(twoNumbers);
                Console.ReadLine();
            }
        }
    }
}
