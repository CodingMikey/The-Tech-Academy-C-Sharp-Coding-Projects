using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers usersInput = new Numbers();
            string numbers = " 1.) 5 x 10 \n 2.) 10 x 10 \n 3.) 25 x 10";

            Console.WriteLine(numbers);
            Console.WriteLine("what number do you want to do the math operations on?");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber == 1)
            {
                Console.WriteLine(usersInput.multiply().ToString());
                Console.ReadLine();
            }
            else if (inputNumber == 2)
            {
                Console.WriteLine(usersInput.multiplyTwo().ToString());
                Console.ReadLine();
            }
            else if (inputNumber == 3)
            {
                Console.WriteLine(usersInput.multiplyThree().ToString());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please pick between 1-3");
                Console.ReadLine();
            }
        }
        
    }
}
