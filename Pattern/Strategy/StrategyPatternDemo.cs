using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    class StrategyPatternDemo
    {
        public static void Test()
        {
            var context_add = new Context(new OperationAdd());
            var result_add = context_add.ExecuteStrategy(10, 5);
            Console.WriteLine(result_add);
            var context_substract = new Context(new OperationSubstract());
            var result_Substract = context_substract.ExecuteStrategy(10, 5);
            Console.WriteLine(result_Substract);
            var context_multiply = new Context(new OperationMultipley());
            var result_Multiplay = context_multiply.ExecuteStrategy(10, 5);
            Console.WriteLine(result_Multiplay);



        }
    }
}
