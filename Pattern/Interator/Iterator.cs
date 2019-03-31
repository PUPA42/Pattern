using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Iterator
{
    interface Iterator
    {
        bool HasNext();
        Object Next();
    }
}
