using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge
{
    class GreenCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Draw green circle ,radius = " + radius + ",position =(" + x + "," + y + ")");
        }
    }
}
