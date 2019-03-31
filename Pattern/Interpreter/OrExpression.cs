using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Interpreter
{
    class OrExpression : IExpression
    {
        private IExpression m_expr1 = null;
        private IExpression m_expr2 = null;

        public OrExpression(IExpression expr1, IExpression expr2)
        {
            this.m_expr1 = expr1;
            this.m_expr2 = expr2;
        }

        public bool Interpret(string context)
        {
            return m_expr1.Interpret(context) || m_expr2.Interpret(context);
        }
    }
}
