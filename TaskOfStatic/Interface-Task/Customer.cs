using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Task
{
    public class Customer
    {

        public static int count = 0;

        public Customer()
        {
            count++;
        }

        public static void GetCount()
        {
            Console.WriteLine(count);
        }

    }
}
