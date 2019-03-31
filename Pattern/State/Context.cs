using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.State
{
    class Context
    {
        private IState m_state;
        public void SetState(IState state)
        {
            m_state = state;
        }
        public IState GetState()
        {
            return m_state;
        }
    }
}
