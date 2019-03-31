using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.State
{
    class StartState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state.");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Start State";
        }
    }
}
