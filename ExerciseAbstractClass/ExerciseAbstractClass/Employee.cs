﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractClass
{
    public class Employee<T> /*: Person IQuittable*/
    {
        public List<T> Things { get; set; }

        public void sayThings()
        {
            foreach (T i in Things)
            {
                Console.WriteLine(i);
            }
        }

        //public override void SayName()
        //{
        //    base.SayName();
        //}
        //public void Quit()
        //{
        //    Console.WriteLine(firstName + lastName + "Employee below is to be fired:");
        //}

    }
}
