using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //string x = "Hello there! I'm ";
            //string y = "Michael. ";
            //string z = "It's nice to meet you.";

            //string all = string.Concat(x, y, z);

            //y = y.ToUpper();
            //Console.WriteLine(y);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("I\'m excited to gradute coding bootcamp. I\'m learnings alot! ");
            sb.Append("I find coding fascinating and love the challenges it comes with. ");
            sb.Append("I would love to get a job creating custom applications to help solve real world issues.");

                
            Console.WriteLine(sb);
            Console.ReadLine();

            
        }
    }
}
