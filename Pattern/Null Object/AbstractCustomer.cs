using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Null_Object
{
    abstract class AbstractCustomer
    {
        protected string m_name;
        public abstract bool IsNil();

        public abstract string GetName();
    }
}
