using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Memento
{
    class Originator
    {
        private string m_state;
        public void SetState(string state)
        {
            m_state = state;
        }
        public string GetState()
        {
            return m_state;
        }
        public Memento SaveStateToMemento()
        {
            return new Memento(m_state);
        }
        public string GetStateFromMemento(Memento memento)
        {
            return memento.GetState();
        }

    }
}
