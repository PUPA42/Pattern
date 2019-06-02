using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    class VisitorPatternDemo
    {
        private VisitorPatternDemo() { }
        public static void Test()
        {
            var computer = new Computer(new IComputerPart[] {new Monitor(),new KeyBoard(),new Mouse() });
            var visitor = new ComputerDisplayVisitor();
            computer.Accept(visitor);
        }
    }
}
