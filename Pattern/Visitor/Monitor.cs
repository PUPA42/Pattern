using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    class Monitor : IComputerPart
    {
        public void Accept(IComputerVisitor computerVisitor)
        {
            computerVisitor.Visit(this);
        }
    }
}
