using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FlyWeight
{
    class ShapeFactory
    {
        private static Hashtable s_hashtable = new Hashtable();

        public static IShape GetShape(string color)
        {
            if (!s_hashtable.ContainsKey(color))
            {
                var circle = new Circle(color);
                s_hashtable.Add(color,circle);
                Console.WriteLine("Create circle :"+color);
                return circle;
            }
            else
            {
                return (IShape)s_hashtable[color];
            }
        }
    }
}
