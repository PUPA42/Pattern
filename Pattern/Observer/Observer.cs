using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    public abstract class Observer
    {
        protected Subject m_subject;
        public Observer(Subject subject) {
            m_subject = subject;
        }
        public abstract void Update();
    }
}
