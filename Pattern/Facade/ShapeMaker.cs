using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Facade
{
    class ShapeMaker
    {
        private IShape m_circle;
        private IShape m_rectangle;

        public ShapeMaker()
        {
            m_circle = new Circle();
            m_rectangle = new Rectangle();
        }

        public void DrawCircle()
        {
            m_circle.Draw();
        }
        public void DrawRectangle()
        {
            m_rectangle.Draw();
        }

    }
}
