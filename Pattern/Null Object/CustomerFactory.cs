using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Null_Object
{
    class CustomerFactory
    {
        public static String[] m_names = { "Rob", "Joe", "Julie" };
        public static AbstractCustomer GetCustomer(string name)
        {
            for (int i = 0; i < m_names.Length; i++)
            {
                if (m_names[i] == name)
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }

    }
}
