using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ServiceLocator
{
    interface IService
    {
        string GetName();
        void Execute();
    }
}
