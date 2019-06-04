using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ServiceLocator
{
    class ServiceLocator
    {
        private static Cache s_cache;

        static ServiceLocator(){
            s_cache=new Cache();
        }
        public static IService GetService(string jndiName) {
            var service = s_cache.GetService(jndiName);
            if (service!=null)
            {
                return service;
            }
            var context = new InitialContext();
            var service1 = (IService)context.LookUp(jndiName);
            s_cache.AddService(service1);
            return service1;
        }
    }
}

