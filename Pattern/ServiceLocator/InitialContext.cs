using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ServiceLocator
{
    class InitialContext
    {
        public object LookUp(string jndiName) {
            if (jndiName.ToUpper().Equals("SERVICE1"))
            {
                Console.WriteLine("Looking up and creating a new Service1 object.");
                return new Service1();
            }
            else if (jndiName.ToUpper().Equals("SERVICE2"))
            {
                Console.WriteLine("Looking up and creating a new Service2 object.");
                return new Service2();
            }
            return null;
        }
    }
}
