using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FlyWeight
{
    class Circle : IShape
    {
        private string m_color;
        private int m_x;
        private int m_y;
        private int m_radius;

        public Circle(string color)
        {
            this.m_color = color;
        }
        public void SetX(int x)
        {
            m_x = x;
        }
        public void SetY(int y)
        {
            m_y = y;
        }
        public void SetRadius(int radius)
        {
            m_radius = radius;
        }

        public void Draw()
        {
            var sb = new StringBuilder("[Draw Circle],Color:").Append(m_color)
                .Append(",X:").Append(m_x).Append(",Y:").Append(m_y).Append(",Radius:")
                .Append(m_radius);
            Console.WriteLine(sb.ToString());
        }
    }
}
