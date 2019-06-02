using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    class ComputerDisplayVisitor : IComputerVisitor
    {
        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Display mouse");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Display monitor");
        }

        public void Visit(KeyBoard keyBoard)
        {
            Console.WriteLine("Display keyBoard");
        }

        public void Visit(Computer computer)
        {
            Console.WriteLine("Display computer");
        }
    }
}
