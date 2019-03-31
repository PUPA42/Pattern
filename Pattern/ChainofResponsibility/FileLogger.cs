using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ChainofResponsibility
{
    class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            m_level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("File Log:" + message);
        }
    }
}
