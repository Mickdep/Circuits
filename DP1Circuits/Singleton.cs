using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DP1Circuits
{
    public class Singleton<T> where T : class
    {
        protected Singleton() { }

        public static T Instance
        {
            get { return SingletonCreator.instance; }
        }

        class SingletonCreator
        {
            // static SingletonCreator() { } redundant as it is created by the compiler automatically
            internal static readonly T instance = typeof(T).InvokeMember(typeof(T).Name,
                               BindingFlags.CreateInstance |
                               BindingFlags.Instance |
                               BindingFlags.NonPublic |
                               BindingFlags.Public,
                               null, null, null) as T;
        }
    }
}
