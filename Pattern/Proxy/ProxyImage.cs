using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Proxy
{
    class ProxyImage : IImage
    {
        private RealImage m_realImage;
        private string m_fileName;

        public ProxyImage(string fileName)
        {
            this.m_fileName = fileName;
        }

        public void Display()
        {
            if (m_realImage==null)
            {
                m_realImage = new RealImage(m_fileName);
            }
            m_realImage.Display();
        }
    }
}
