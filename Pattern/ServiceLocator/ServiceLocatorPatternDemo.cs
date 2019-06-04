using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ServiceLocator
{
    class ServiceLocatorPatternDemo
    {
        public static void Test()
        {
            var service = ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.GetService("Service2");
            service.Execute();
            service = ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.GetService("Service2");
            service.Execute();
        }
    }
}
