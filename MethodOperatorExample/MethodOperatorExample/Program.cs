using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOperatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();
            int num1 = 88;
            


            int resultOne = mathOperations.addition(num1);
            

            decimal resultTwo = mathOperations.addition(15m);
            

            int resultThree = mathOperations.addition("15");
            Console.WriteLine("{0} - {1} - {2}", resultOne, resultTwo, resultThree);

            
            Console.ReadLine();
        }
    }
}
