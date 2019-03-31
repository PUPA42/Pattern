using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Abstract_Factory
{
    class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(ColorType type)
        {
            return null;
        }

        public override IShape GetShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Square:
                    return new Square();
                case ShapeType.Rectangle:
                    return new Rectangle();
            }
            return null;
        }
    }
}
