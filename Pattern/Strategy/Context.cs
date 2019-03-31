using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    class Context
    {
        private IStrategy m_strategy;

        public Context(IStrategy m_strategy)
        {
            this.m_strategy = m_strategy;
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return m_strategy.DoOperation(num1, num2);
        }
    }
}
