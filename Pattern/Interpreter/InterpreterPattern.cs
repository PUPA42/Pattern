using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Interpreter
{
    class InterpreterPattern
    {
        public static IExpression GetMaleExpression()
        {
            var robert = new TerminalExpression("Rebort");
            var john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        public static IExpression GetMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie,married);
        }
    }
}
