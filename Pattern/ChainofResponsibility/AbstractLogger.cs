using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ChainofResponsibility
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;
        protected int m_level;
        protected AbstractLogger m_nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            m_nextLogger = nextLogger;
        }
        public void LogMessage(int level, string message)
        {
            if (this.m_level <= level)
            {
                Write(message);
            }
            if (m_nextLogger != null)
            {
                m_nextLogger.LogMessage(level, message);
            }
        }
        protected abstract void Write(string message);
    }
}
