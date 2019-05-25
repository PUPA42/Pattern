using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    class OctalObserver : Observer
    {
        public OctalObserver(Subject subject) : base(subject)
        {

        }

        public override void Update()
        {
            System.Console.WriteLine("OctalObserber update.State="+m_subject.GetState());
        }
    }
}
