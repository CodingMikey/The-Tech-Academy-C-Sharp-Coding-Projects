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
                InputException inputException = new InputException();
                inputException.ShowAge(age);



                Console.WriteLine("You were born in the year: {0} ", aTime.Year - age);
                Console.ReadLine();
            }
            catch (InputException e)
            {

                Console.WriteLine("Error: {0}", e.Message);
                return;

            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your System Administrator.");
                
                return;

            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
