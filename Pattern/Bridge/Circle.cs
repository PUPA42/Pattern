using Pattern.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge
{
    class Circle : IShape
    {
        public int m_x, m_y, m_radius;
        public Circle(int x, int y, int radius, IDrawAPI drawAPI) : base(drawAPI)
        {
            m_x = x;
            m_y = y;
            m_radius = radius;
        }
        public override void Draw()
        {
            m_drawAPI.DrawCircle(m_radius, m_x, m_y);
        }
    }
}
