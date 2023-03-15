using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns_Singleton_Pattern
{
  public  class Counter
    {
        public int count = 0;
       //bad soluation ==>becausce when app run make object after use the class
       // private static Counter instance = new Counter();

        // good soluation ==>make object when use the class
        private static Counter instance = null;

        private static readonly Object lockObject = new object ();

        private Counter() {}

        public static Counter CreateInstance()
        {
            if(instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null) { instance = new Counter(); }
                  
                }
            }
            return instance;

        }
        public void Add() => count++;
    }
}
