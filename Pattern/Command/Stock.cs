using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Command
{
    class Stock
    {
        private string m_name;
        private int m_quantity;

        public Stock(string m_name, int m_quantity)
        {
            this.m_name = m_name;
            this.m_quantity = m_quantity;
        }

        public void Buy()
        {
            Console.WriteLine("Stock [Name]:" + m_name + " ,[Quantity]:" + m_quantity + " bought");
        }

        public void Sell()
        {
            Console.WriteLine("Stock [Name]:" + m_name + " ,[Quantity]:" + m_quantity + " sold");
        }

    }
}
