using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleTwo
{
    public class InputException : Exception
    {

        public InputException()
            : base() { }
        public InputException(string message)
            : base(message) { }

        
            

            public void ShowAge(int age)
            {
                if (age <= 0)
                {
                    throw (new InputException("You cannot enter zero or a negative number."));
                }

            }
    }
}
