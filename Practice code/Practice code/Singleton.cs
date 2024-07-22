using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    public class Singleton
    {
        private static Singleton singleton;
        private static readonly object lockobj = new object();

        private Singleton() {}

        public static Singleton GetSingleton()
        {
            lock (lockobj)
            {
                if (singleton == null)
                {
                    return new Singleton();
                }
            }
            return singleton;
        }
    }
}
