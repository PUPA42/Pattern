using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Singleton
{
    class Singleton
    {
        private static Singleton _instance = new Singleton();
        private Singleton() { }

        public static Singleton GetInstance()
        {
            return _instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World.");
        }


    }
}
