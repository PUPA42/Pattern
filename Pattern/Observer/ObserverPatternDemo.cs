using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    class ObserverPatternDemo
    {
        public static void Test()
        {
            var subject = new Subject();
            var bo = new BinaryObserver(subject);
            var ho = new HexaObserver(subject);
            var oo = new OctalObserver(subject);
            subject.Attach(bo);
            subject.Attach(ho);
            subject.Attach(oo);
            subject.SetState(1);
            subject.SetState(2);
        }

    }
}
