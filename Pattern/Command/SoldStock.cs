using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Command
{
    class SoldStock : IOrder
    {
        private Stock m_stock;
        public SoldStock(Stock stock)
        {
            m_stock = stock;
        }
        public void Execute()
        {
            m_stock.Sell();
        }
    }
}
