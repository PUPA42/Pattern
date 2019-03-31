using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge
{
    public interface IDrawAPI
    {
        void DrawCircle(int radius, int x, int y);
    }
}
