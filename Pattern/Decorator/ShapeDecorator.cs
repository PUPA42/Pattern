using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Decorator
{
    class ShapeDecorator : IShape
    {
        protected IShape m_decoratedShape;

        public ShapeDecorator(IShape shapeDecorator)
        {
            m_decoratedShape = shapeDecorator;
        }
        public virtual void Draw()
        {
            m_decoratedShape.Draw();
        }
    }
}
