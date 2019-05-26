using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.NullObjectPattern
{
    public class NullCustomer : AbstractCustomer
    {
        public override string GetName()
        {
            return "Not Available in Customer Database";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}
