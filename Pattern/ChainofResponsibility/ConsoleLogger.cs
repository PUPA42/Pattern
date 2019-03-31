using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ChainofResponsibility
{
    class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            m_level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Console log:" + message);
        }
    }
}
