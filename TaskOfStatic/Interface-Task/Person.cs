using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Task
{
    public  class Person
    {
        public static int Age { get; set; }

         static Person()
        {
            Console.WriteLine("Welcome");
        }

        public Person()
        {
            Console.WriteLine("Non static constructor");
        }


        public static void GetName()
        {
            Console.WriteLine("Text");
        }

        public static void GetSurName()
        {
            Console.WriteLine("Text");
        }
    }
}
