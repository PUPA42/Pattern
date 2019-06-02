using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    interface IComputerVisitor
    {
        void Visit(Mouse mouse);
        void Visit(Monitor monitor);
        void Visit(KeyBoard keyBoard);
        void Visit(Computer computer);
    }
}
