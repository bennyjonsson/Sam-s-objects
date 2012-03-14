using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sam
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int i = 0;
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        public int I() { i++; return i; }
        public void Reset() {i = 0;}

    }

    public abstract class Food {
        public string Eat() {
            Singleton singleton = Singleton.Instance;
            if (singleton.I() > 5)
            {
                singleton.Reset();
                throw new Exception("Puke");
            }
            return "Yumm"; }
    }
}
