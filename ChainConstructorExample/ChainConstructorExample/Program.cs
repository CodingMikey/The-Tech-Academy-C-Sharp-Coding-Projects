using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Coding Mikey!";

            var myAge = 29;

            Person person = new Person("Mike", 5);



            Console.WriteLine(person);
            Console.ReadLine();

        }
    }
    public class Person
    {

        public Person(string name) : this(name, 100)
        {

        }
        public Person(string name, int age)
        {
            age = age;
            name = name;

        }
        
        
    }
    
}
