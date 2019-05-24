
using Pattern.ChainofResponsibility;
using Pattern.Command;
using Pattern.Iterator;
using Pattern.Memento;
using System;
using System.Threading;

namespace Pattern
{
    class Pragram
    {
        static void Main(string[] args)
        {
            var mementoDemo = new MementoPatternDemo();
            mementoDemo.Test();

            System.Console.ReadLine();
        }
    }
}