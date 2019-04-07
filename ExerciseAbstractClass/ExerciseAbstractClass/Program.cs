using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();

            quittable.Quit();

            Employee person = new Employee();
            person.firstName = "Sample";
            person.lastName = "Sample ";
            

            person.SayName();
        
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
