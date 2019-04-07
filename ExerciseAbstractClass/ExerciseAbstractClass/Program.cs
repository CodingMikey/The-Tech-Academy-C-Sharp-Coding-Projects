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

            Employee<string> list1 = new Employee<string>();

            list1.Things = new List<string>();

            list1.Things.Add("Cat");
            list1.Things.Add("Dog");
            list1.Things.Add("Duck");

            Employee<int> list2 = new Employee<int>();

            list2.Things = new List<int>();

            list2.Things.Add(5);
            list2.Things.Add(6);
            list2.Things.Add(9);



            list1.sayThings();
            list2.sayThings();
                
            Console.WriteLine();
            Console.ReadLine();
                

            //IQuittable quittable = new Employee();

            //quittable.Quit();

            //Employee person = new Employee();
            //person.firstName = "Sample ";
            //person.lastName = "Student";


            //person.SayName();

            //Console.WriteLine();
            //Console.ReadLine();
        }
    }
}
