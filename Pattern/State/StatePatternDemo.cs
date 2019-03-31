using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.State
{
    class StatePatternDemo
    {
        public static void Test()
        {
            var context = new Context();
            var startState = new StartState();
            startState.DoAction(context);
            Console.WriteLine(context.GetState());
            var stopState = new StopState();
            stopState.DoAction(context);
            Console.WriteLine(context.GetState());
        }
    }
}
