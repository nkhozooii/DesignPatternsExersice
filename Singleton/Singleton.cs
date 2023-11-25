using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        // private static readonly Singleton uniqeInstance = new Singleton();
        //For LazyInitializer:
        private static readonly Lazy<Singleton> uniqeInstance = new(() => new Singleton());

        private Singleton()
        {
                
        }
        public static Singleton getInstance()
        {            
            return uniqeInstance.Value;
        }
    }
}
