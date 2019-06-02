using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Template
{
    class TemplatePatternDemo
    {
        private TemplatePatternDemo() { }
        public static void Test()
        {
            Game game = new Cricket();
            game.Play();
            game = new FootBall();
            game.Play();
        }

    }
}
