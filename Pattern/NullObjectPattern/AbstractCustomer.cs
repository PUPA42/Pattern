using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.NullObjectPattern
{
    public abstract class AbstractCustomer
    {
        protected string m_name;
        public abstract bool IsNull();
        public abstract string GetName();
    }
}
