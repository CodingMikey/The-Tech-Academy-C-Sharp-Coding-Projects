using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Numbers
    {
        public int numbersClass(int num1, int num2 = 0)
        {
            int results = num1 + num2 + 10;

            return results;
        }
    }
}
