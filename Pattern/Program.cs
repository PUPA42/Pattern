
using Pattern.ChainofResponsibility;
using Pattern.Command;
using Pattern.Iterator;
using System;
using System.Threading;

namespace Pattern
{
    class Pragram
    {
        static void Main(string[] args)
        {
            var rob = Null_Object.CustomerFactory.GetCustomer("Rob");
            var peter = Null_Object.CustomerFactory.GetCustomer("Peter");

            Console.WriteLine(rob.GetName());
            Console.WriteLine(peter.GetName());
            

            Console.ReadLine();
        }

    }
}