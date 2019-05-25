
using Pattern.ChainofResponsibility;
using Pattern.Command;
using Pattern.Iterator;
using Pattern.Memento;
using Pattern.Observer;
using System;
using System.Threading;

namespace Pattern
{
    class Pragram
    {
        static void Main(string[] args)
        {
            ObserverPatternDemo.Test();
            System.Console.ReadLine();
        }
    }
}