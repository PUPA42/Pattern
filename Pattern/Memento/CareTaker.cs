using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Memento
{
    class CareTaker
    {
        private List<Memento> m_mementoList = new List<Memento>();

        public void Add(Memento mem)
        {
            m_mementoList.Add(mem);
        }
        public Memento Get(int index)
        {
            return m_mementoList[index];
        }

    }
}
