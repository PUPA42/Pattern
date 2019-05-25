using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject) : base(subject)
        {
        }

        public override void Update()
        {
            System.Console.WriteLine("BinaryObserber Update.State="+m_subject.GetState());
        }
    }
}
