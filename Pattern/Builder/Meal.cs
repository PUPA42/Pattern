using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builder
{
    class Meal
    {
        private List<Item> m_item_List = new List<Item>();

        public void AddItem(Item item)
        {
            m_item_List.Add(item);
        }

        public float GetCost()
        {
            var cost = 0f;
            for (int i = 0; i < m_item_List.Count; i++)
            {
                cost += m_item_List[i].Price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in m_item_List)
            {
                Console.WriteLine("Name = " + item.Name());
                Console.WriteLine("Packing = " + item.Packing());
                Console.WriteLine("Price = "+item.Price());
            }
        }

    }
}
