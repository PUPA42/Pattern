using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Decorator
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape:Circle");
        }
    }
}
