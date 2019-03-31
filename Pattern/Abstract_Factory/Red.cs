using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Abstract_Factory
{
    class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill Red.");
        }
    }
}
