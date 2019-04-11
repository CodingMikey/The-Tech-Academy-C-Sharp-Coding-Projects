using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instantiated from class Employee to create employee list

            List<Employee> empList = new List<Employee>();


            //List of 10 employees. First name, last name, ID #

            empList.Add(new Employee()
            {
                Id = 1,
                FirstName = "Joe",
                LastName = "Jane"
            });
            empList.Add(new Employee()
            {
                Id = 2,
                FirstName = "Joe",
                LastName = "Frank"
            });
            empList.Add(new Employee()
            {
                Id = 3,
                FirstName = "Mike",
                LastName = "Blue"
            });
            empList.Add(new Employee()
            {
                Id = 4,
                FirstName = "Roman",
                LastName = "Green"
            });
            empList.Add(new Employee()
            {
                Id = 5,
                FirstName = "James",
                LastName = "Janeny"
            });
            empList.Add(new Employee()
            {
                Id = 6,
                FirstName = "Andrey",
                LastName = "Gales"
            });
            empList.Add(new Employee()
            {
                Id = 7,
                FirstName = "Mikhail",
                LastName = "Olvie"
            });
            empList.Add(new Employee()
            {
                Id = 8,
                FirstName = "Smith",
                LastName = "Jr"
            });
            empList.Add(new Employee()
            {
                Id = 9,
                FirstName = "Alex",
                LastName = "Hiu"
            });
            empList.Add(new Employee()
            {
                Id = 10,
                FirstName = "Mira",
                LastName = "Helm"
            });

            //Foreach loop to print out all employees with first name Joe.

            foreach (var data in empList)
            {
                if (data.FirstName == "Joe")
                {
                    Console.WriteLine("{0}, {1}, {2}", data.FirstName, data.LastName, data.Id);
                   
                }
                Console.ReadLine();
            }
        }
        
    }
    
}
