using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Interpreter
{
    interface IExpression
    {
        bool Interpret(string context);
    }
}
