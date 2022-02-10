using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// 单例模式
    /// 1. 只能有一个实例
    /// 2. 只能自己创建自己的唯一实例
    /// 3. 必须给所有其他的对象提供这一实例
    /// </summary>
    public class SingletonDesign
    {
        private static SingletonDesign singleton;

        private SingletonDesign() { }

        /// <summary>
        /// 获取实例-线程非安全模式
        /// </summary>
        public static SingletonDesign GetSingleton()
        { 
            if (singleton == null)
                singleton = new SingletonDesign();
            return singleton;
        }

        /// <summary>
        /// 考虑线程安全
        /// </summary>
        public class SingletonDesign1
        { 
            private static object obj = new object();
            private static SingletonDesign1 singleton;
            private SingletonDesign1() { }

            /// <summary>
            /// 获取实例-线程安全
            /// </summary>
            public static SingletonDesign1 GetThreadSafeSingleton()
            { 
                if (singleton == null)
                {
                    lock (obj)
                    {
                        if (singleton == null)
                        {
                            singleton = new SingletonDesign1();
                        }
                    }
                }
                return singleton;
            }
        }
    }
}
