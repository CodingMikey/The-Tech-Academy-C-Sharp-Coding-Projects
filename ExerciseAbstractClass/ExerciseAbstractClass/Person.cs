using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractClass
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }
        public static bool operator == (Person firstName, Person lastName)
        {
            if (firstName == lastName)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Person firstName, Person lastName)
        {
            if (firstName != lastName)
            {
                return false;
            }
            else return true;
                
        }
    }
}
