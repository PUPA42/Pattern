
using System;

namespace Pattern.ProtoType
{
    public class Circle : Shape
    {
        public Circle() {
            m_shapeType = "Circle";
        }
        public override void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }
}
