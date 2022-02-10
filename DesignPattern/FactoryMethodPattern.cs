using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// 在简单工厂模式中通过工厂Factory获取不通对象，但有一个明显缺点就是难以扩展，添加新产品需要修改
    /// 通过工厂方法模式可以解决简单工厂模式中存在的问题
    /// </summary>
    public class FactoryMethodPattern
    {
        /// <summary>
        /// 汽车抽象类
        /// </summary>
        public abstract class AuthCar
        {
            /// <summary>
            /// 输出制造了什么汽车
            /// </summary>
            public abstract void CreatorCar();
        }
    }
}
