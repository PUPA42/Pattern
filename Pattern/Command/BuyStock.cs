using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Command
{
    class BuyStock : IOrder
    {
        private Stock m_stock;
        public BuyStock(Stock stock)
        {
            m_stock = stock;
        }
        public void Execute()
        {
            m_stock.Buy();
        }
    }
}
