using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.NullObjectPattern
{
    class NullObjectPatternDemo
    {
        public static void Test()
        {
            var customer_0 = CustomerFactory.GetCustomer("Rob");
            var customer_1 = CustomerFactory.GetCustomer("Bob");
            var customer_2 = CustomerFactory.GetCustomer("Julie");
            var customer_3 = CustomerFactory.GetCustomer("Laura");

            System.Console.WriteLine("Customers");

            System.Console.WriteLine(customer_0.GetName());
            System.Console.WriteLine(customer_1.GetName());
            System.Console.WriteLine(customer_2.GetName());
            System.Console.WriteLine(customer_3.GetName());

        }
    }
}
