
using Pattern.ChainofResponsibility;
using Pattern.Command;
using Pattern.Iterator;
using System;
using System.Threading;

namespace Pattern
{
    class Pragram
    {
        static void Main(string[] args)
        {
            Strategy.StrategyPatternDemo.Test();
            Console.ReadLine();
        }
    }
}