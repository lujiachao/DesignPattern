using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPattern.FactoryMethodPattern;

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

        /// <summary>
        /// 派生类-橘黄色轿车
        /// </summary>
        public class _OriangeCar : AuthCar
        {
            public override void CreatorCar()
            {
                Console.WriteLine("生产了橘黄色轿车");
            }
        }

        /// <summary>
        /// 派生类-黑色轿车
        /// </summary>
        public class _BlackCar : AuthCar
        {
            public override void CreatorCar()
            {
                Console.WriteLine("生产了黑色轿车");
            }
        }
    }

    /// <summary>
    /// 工厂类
    /// </summary>
    public abstract class FactoryCreator
    {
        /// <summary>
        /// 获取汽车对象
        /// </summary>
        public abstract AuthCar _AuthCar();

        /// <summary>
        /// 得到黑色汽车实例
        /// </summary>
        public class BlackCarFactoryMethod : FactoryCreator
        {
            public override AuthCar _AuthCar()
            {
                return new _BlackCar();
            }
        }

        /// <summary>
        /// 得到橘黄色汽车实例
        /// </summary>
        public class OriangeFactoryMethod : FactoryCreator
        {
            public override AuthCar _AuthCar()
            {
                return new _OriangeCar();
            }
        }
    }
}
