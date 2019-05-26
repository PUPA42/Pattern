using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.NullObjectPattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            m_name = name;
        }
        public override string GetName()
        {
            return m_name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}
