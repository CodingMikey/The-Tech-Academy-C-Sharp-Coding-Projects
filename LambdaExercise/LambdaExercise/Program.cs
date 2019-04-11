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

            List<Employee> empList = new List<Employee>();


            

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

            

            foreach (var data in empList)
            {
                Console.WriteLine("My Id is {0} and my full name is {1} {2}", data.Id, data.FirstName, data.LastName);
            }
            Console.ReadLine();

        }
        
    }
    
}
