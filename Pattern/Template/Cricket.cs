using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Template
{
    class Cricket : Game
    {
        public override void EndPlay()
        {
            System.Console.WriteLine("Cricket End Play");
        }

        public override void Initialize()
        {
            System.Console.WriteLine("Cricket Initialize");
        }

        public override void StartPlay()
        {
            System.Console.WriteLine("Cricket Start Play");
        }

    }
}
