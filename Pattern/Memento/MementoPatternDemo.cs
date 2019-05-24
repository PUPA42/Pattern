using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Memento
{
    class MementoPatternDemo
    {
        public void Test()
        {
            var originator = new Originator();
            var careTaker = new CareTaker();
            originator.SetState("State #1");
            careTaker.Add(originator.SaveStateToMemento());
            originator.SetState("State #2");
            careTaker.Add(originator.SaveStateToMemento());
            originator.SetState("State #3");
            careTaker.Add(originator.SaveStateToMemento());


            System.Console.WriteLine("First Saved State: " + careTaker.Get(0).GetState());
            System.Console.WriteLine("Current State: " + originator.GetState());

        }
    }
}
