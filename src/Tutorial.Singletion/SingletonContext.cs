using System;

namespace Tutorial.Singletion
{
    public class SingletonContext
    {
        private static SingletonContext context;
        private static Object obj = new Object();
        private SingletonContext() { }

        public static SingletonContext ContextInstance
        {
            get
            {
                if (context == null)
                    return new SingletonContext();
                return context;
            }
        }

        // Multi threat
        public static SingletonContext ContextMultiThreatInstance
        {
            get
            {
                if (context == null)
                    lock (obj)
                    {
                        if (context == null)
                        {
                            context = new SingletonContext();
                        }
                    }
                return context;
            }
        }
    }
}
