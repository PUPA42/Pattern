using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    public class Subject
    {
        private List<Observer> m_observers =new List<Observer>();

        private int m_state;

        public int GetState() {
            return m_state;
        }
        public void SetState(int state) {
            m_state = state;
            NotifyAllObservers();
        }
        public void Attach(Observer observer) {
            m_observers.Add(observer);
        }
        public void NotifyAllObservers() {
            foreach (var item in m_observers)
            {
                item.Update();
            }
        }


    }
}
