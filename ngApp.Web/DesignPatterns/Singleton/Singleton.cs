using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.DesignPatterns.Singleton
{
    public class SingletonObject
    {
        private static SingletonObject _instance = new SingletonObject(); //Thread not safe

        public static SingletonObject GetInstance
        {
            get
            {
                return _instance;
            }
        }

        private SingletonObject() { }
    }

    public class SingletonObject2
    {
        private static readonly SingletonObject2 _instance = new SingletonObject2();//readonly threadSafe

        public static SingletonObject2 GetInstance
        {
            get
            {
                return _instance;
            }
        }

        private SingletonObject2()
        {

        }

    }

    public class SingletonObject3
    {
        private static readonly object _lock = new object();
        private static SingletonObject3 _instance;

        public static SingletonObject3 GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonObject3();
                    }

                    return _instance;
                }
            }
        }

        private SingletonObject3()
        {

        }

    }

}
