using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ServiceLocator
{
    class Service2 : IService
    {
        public void Execute()
        {
            Console.WriteLine("Execute Service2");
        }

        public string GetName()
        {
            return "Service2";
        }
    }
}
