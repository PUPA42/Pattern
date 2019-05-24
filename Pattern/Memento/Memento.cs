using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Memento
{
    class Memento
    {
        private String m_state;
        public Memento(String state)
        {
            this.m_state = state;
        }
        public string GetState()
        {
            return m_state;
        }
    }
}
