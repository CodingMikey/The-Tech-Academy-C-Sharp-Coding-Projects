using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add("Cats and Dogs");
            animals.Add("Frogs and snakes");
            animals.Add("Sea Pickles and Sea Biscuits");

            Console.WriteLine("Select an index from 0 to 2! The outcome will be the animals you will live with forever!");
            int selectionThree = Convert.ToInt32(Console.ReadLine());

            if (selectionThree == 0)
            {
                Console.WriteLine(animals[0]);
                Console.ReadLine();
            }
            else if (selectionThree == 1)
            {
                Console.WriteLine(animals[1]);
                Console.ReadLine();
            }
            else if (selectionThree == 2)
            {
                Console.WriteLine(animals[2]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This index does not exsist.");
                Console.ReadLine();
            }
            //int[] ageArray = { 19, 25, 98 };

            //Console.WriteLine("Select an index from 0 to 2! The outcome will be how old you become tomorrow!");
            //int selectionTwo = Convert.ToInt32(Console.ReadLine());

            //if (selectionTwo == 0)
            //{
            //    Console.WriteLine(ageArray[0]);
            //    Console.ReadLine();
            //}
            //else if (selectionTwo == 1)
            //{
            //    Console.WriteLine(ageArray[1]);
            //    Console.ReadLine();
            //}
            //else if (selectionTwo == 2)
            //{
            //    Console.WriteLine(ageArray[2]);
            //    Console.ReadLine();
            //}
            //else 
            //{
            //    Console.WriteLine("This index does not exsist.");
            //    Console.ReadLine();
            //}
            //string[] colorArray = {"Blue", "Yellow", "Green"};

            //Console.WriteLine("Select an index from 0 to 2! That will be the color of your car!");
            //int selectionOne = Convert.ToInt32(Console.ReadLine());

            //if (selectionOne == 0)
            //{
            //    Console.WriteLine(colorArray[0]);
            //    Console.ReadLine();
            //}
            //else if (selectionOne == 1)
            //{
            //    Console.WriteLine(colorArray[1]);
            //    Console.ReadLine();
            //}
            //else if (selectionOne == 2)
            //{
            //    Console.WriteLine(colorArray[2]);
            //    Console.ReadLine();
            //}
        }
    }
}
