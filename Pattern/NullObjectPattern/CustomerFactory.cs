using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.NullObjectPattern
{
    class CustomerFactory
    {
        public static string[] m_names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer GetCustomer(string name)
        {
            if (m_names.Contains(name))
            {
                return new RealCustomer(name);
            }
            return new NullCustomer();
        }
    }
}
