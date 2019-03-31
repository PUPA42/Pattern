using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Abstract_Factory
{
    class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(ColorType type)
        {
            switch (type)
            {
                case ColorType.Red:
                    return new Red();
                case ColorType.Green:
                    return new Green();
            }
            return null;
        }

        public override IShape GetShape(ShapeType type)
        {
            return null;
        }
    }
}
