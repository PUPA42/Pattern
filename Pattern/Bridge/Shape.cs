using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge
{
    public abstract class IShape
    {
        protected IDrawAPI m_drawAPI;
        protected IShape(IDrawAPI drawAPI)
        {
            m_drawAPI = drawAPI;
        }
        public abstract void Draw();
    }
}
