using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.State
{
    class StopState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state.");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Stop State";
        }
    }
}
