using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Abstract_Factory
{
    public enum FactoryType
    {
        ShapeFactory,
        ColorFactory,
    }
    class FactoryProducer
    {
        public AbstractFactory GetFactory(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.ShapeFactory:
                    return new ShapeFactory();
                case FactoryType.ColorFactory:
                    return new ColorFactory();
            }
            return null;
        }
    }
}
