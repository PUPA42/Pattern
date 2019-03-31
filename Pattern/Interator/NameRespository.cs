using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Iterator
{
    class NameRespository : IContainer
    {
        public string[] m_names = { "Robert", "John", "Julie", "Lora" };

        public Iterator GetIterator()
        {
            return new NameIterator(m_names);
        }
        private class NameIterator : Iterator
        {
            private int m_index = -1;
            private string[] m_names;

            public NameIterator(string[] names)
            {
                this.m_names = names;
            }

            public bool HasNext()
            {
                if (m_index < m_names.Length - 1)
                {
                    return true;
                }
                else return false;
            }

            public object Next()
            {
                if (HasNext())
                {
                    m_index++;
                    return m_names[m_index];
                }
                return null;
            }
        }
    }

}
