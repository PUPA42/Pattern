using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ServiceLocator
{
    class Cache
    {
        private List<IService> m_services;
        public Cache() {
            m_services = new List<IService>();
        }

        public IService GetService(string serviceName) {
            foreach (var item in m_services)
            {
                if (item.GetName().Equals(serviceName))
                {
                    Console.WriteLine("Return cached object:"+serviceName);
                    return item;
                }
            }
            return null;
        }
        public void AddService(IService newService) {
            var exists = false;
            foreach (var item in m_services)
            {
                if (item.GetName().Equals(newService.GetName()))
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                m_services.Add(newService);
            }
        }
    }
}
