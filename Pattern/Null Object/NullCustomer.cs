using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Null_Object
{
    class NullCustomer : AbstractCustomer
    {

        public override string GetName()
        {
            return "Not available in Customer database";
        }

        public override bool IsNil()
        {
            return true;
        }
    }
}
