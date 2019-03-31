using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Decorator
{
    class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape shapeDecorator) : base(shapeDecorator)
        {

        }

        public override void Draw()
        {
            base.Draw();
            SetRedBorder();
        }

        private void SetRedBorder()
        {
            Console.WriteLine("Border color:Red");
        }
    }
}
