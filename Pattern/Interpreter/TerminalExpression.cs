using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Interpreter
{
    class TerminalExpression : IExpression
    {
        private string m_data;
        public TerminalExpression(string data)
        {
            m_data = data;
        }
        public bool Interpret(string context)
        {
            if (context.Contains(m_data))
            {
                return true;
            }
            return false;
        }
    }
}
