using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Factory_Pattern
{
    public enum ShapeType
    {
        Circle,
        Square,
        Rectangle
    }
    class ShapeFactory
    {
        public IShape GetShape(ShapeType type)
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

        public IShape GetShape<T>() where T : IShape
        {
            try
            {
                var type = typeof(T);
                var obj = (T)type.Assembly.CreateInstance(type.ToString());
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IShape GetShapeByName(string shapeName)
        {
            var type = Type.GetType(shapeName);
            var obj = type.Assembly.CreateInstance(shapeName);
            return obj as IShape;
        }

    }
}
