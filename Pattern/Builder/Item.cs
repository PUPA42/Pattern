
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builder
{
    interface Item
    {
        String Name();
        IPacking Packing();
        float Price();

    }
}
