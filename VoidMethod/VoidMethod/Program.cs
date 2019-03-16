using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 25;
            
            Numbers numbers = new Numbers();

            numbers.numbers(num1, num2);
            Console.ReadLine();
        }

        
    }
   
}
