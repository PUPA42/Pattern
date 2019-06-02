using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    class Computer : IComputerPart
    {
        private IComputerPart[] m_computerParts;
        public Computer(IComputerPart[] computerParts)
        {
            m_computerParts = computerParts;
        }
        public void Accept(IComputerVisitor computerVisitor)
        {
            for (int i = 0; i < m_computerParts.Length; i++)
            {
                m_computerParts[i].Accept(computerVisitor);
            }
            computerVisitor.Visit(this);
        }
    }
}
