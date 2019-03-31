using System;

namespace Pattern.ProtoType
{

    public class Rectangle : Shape
    {
        public Rectangle()
        {
            m_shapeType = "Rectangle";
        }


        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }

}