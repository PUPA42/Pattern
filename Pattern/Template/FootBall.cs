using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Template
{
    class FootBall : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("FootBall End Play");
        }

        public override void Initialize()
        {
            Console.WriteLine("FootBall Initialize");
        }

        public override void StartPlay()
        {
            Console.WriteLine("FootBall Start");
        }
    }
}
