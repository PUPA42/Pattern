using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    interface IComputerPart
    {
        void Accept(IComputerVisitor computerVisitor);
    }
}
