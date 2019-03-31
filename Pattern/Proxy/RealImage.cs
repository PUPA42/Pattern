using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Proxy
{
    class RealImage : IImage
    {
        private string m_filaName;

        public RealImage(string filaName)
        {
            this.m_filaName = filaName;
            LoadFromDisk();
        }



        public void Display()
        {
            Console.WriteLine("Display : " + m_filaName);
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading : " + m_filaName);
        }
    }
}
