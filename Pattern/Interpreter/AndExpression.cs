using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Interpreter
{
    class AndExpression : IExpression
    {
        private IExpression m_expr1;
        private IExpression m_expr2;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            this.m_expr1 = expr1;
            this.m_expr2 = expr2;
        }

        public bool Interpret(string context)
        {
            return m_expr1.Interpret(context) && m_expr2.Interpret(context);
        }
    }
}
