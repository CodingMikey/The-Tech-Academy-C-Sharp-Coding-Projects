using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter in your age");
                int age = Convert.ToInt32(Console.ReadLine());


                DateTime aTime = DateTime.Now;


                Console.WriteLine("You were born in the year: {0} ", aTime.Year - age);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Please type a positive.");
                
                return;

            }
            
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
