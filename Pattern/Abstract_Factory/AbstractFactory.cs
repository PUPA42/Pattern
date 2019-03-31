using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Abstract_Factory
{
    public enum ShapeType
    {
        Circle,
        Square,
        Rectangle
    }
    public enum ColorType
    {
        Red,
        Green
    }
    abstract class AbstractFactory
    {
        public abstract IShape GetShape(ShapeType type);
        public abstract IColor GetColor(ColorType type);
    }
}
