using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class AbstractFactoryPattern
    {
        /// <summary>
        /// 三星手机输出
        /// </summary>
        public class _SamsungPhone : Mobile
        {
            public override void DisplayMobile()
            {
                Console.WriteLine("生产三星手机");
            }
        }

        /// <summary>
        /// 三星屏幕输出
        /// </summary>
        public class _SamsungScreen : Screen
        {
            public override void DisplayScreen()
            {
                Console.WriteLine("生产三星屏幕");
            }
        }

        /// <summary>
        /// LG 手机类输出
        /// </summary>
        public class _LGPhone : Mobile
        {
            public override void DisplayMobile()
            {
                Console.WriteLine("生产LG手机");
            }
        }

        /// <summary>
        ///  LG 屏幕输出
        /// </summary>
        public class _LGScreen : Screen
        {
            public override void DisplayScreen()
            {
                Console.WriteLine("生产LG屏幕");
            }
        }

        public abstract class AbstractFactorys
        {
            /// <summary>
            /// 获取屏幕产品
            /// </summary>
            public abstract Screen screen();

            /// <summary>
            /// 获取手机产品
            /// </summary>
            public abstract Mobile Mobile();
        }

        /// <summary>
        /// 屏幕抽象类
        /// </summary>
        public abstract class Screen
        {
            public abstract void DisplayScreen();
        }

        /// <summary>
        /// 手机抽象类
        /// </summary>
        public abstract class Mobile
        {
            public abstract void DisplayMobile();
        }

        /// <summary>
        /// LG生产工厂
        /// </summary>
        public class LGFactory : AbstractFactorys
        {
            /// <summary>
            ///  获取LG生产的手机
            /// </summary>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public override Mobile Mobile()
            {
                return new _LGPhone();
            }

            /// <summary>
            ///  获取LG生产的屏幕
            /// </summary>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public override Screen screen()
            {
                return new _LGScreen();
            }
        }

        /// <summary>
        /// 三星实例工厂
        /// </summary>
        public class SamsungFactory : AbstractFactorys
        {
            /// <summary>
            /// 三星生产的手机
            /// </summary>
            public override Mobile Mobile()
            {
                return new _SamsungPhone();
            }
            /// <summary>
            /// 三星生产的屏幕
            /// </summary>
            /// <returns></returns>
            public override Screen screen()
            {
                return new _SamsungScreen();
            }
        }
    }
}
