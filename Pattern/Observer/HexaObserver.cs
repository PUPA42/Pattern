using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    class HexaObserver : Observer
    {
        public HexaObserver(Subject subject) : base(subject)
        {

        }
        public override void Update()
        {
            System.Console.WriteLine("HexaObserver Update.State="+m_subject.GetState());
        }
    }
}
