using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ServiceLocator
{
    class Service1 : IService
    {
        public void Execute()
        {
            Console.WriteLine("Executing Service1");
        }

        public string GetName()
        {
            return "Service1";
        }
    }
}
