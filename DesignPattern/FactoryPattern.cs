using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// 简单工厂模式
    /// 例如 创建一个汽车接口，通过工厂Factory创建实现接口的对象，根据我们的选择来创建不同的对象
    /// </summary>
    public interface IAutoCarMake
    {
        /// <summary>
        /// 创建汽车
        /// </summary>
        void CreateAutoCar();
    }

    /// <summary>
    /// 红色小轿车
    /// </summary>
    public class _RedCar : IAutoCarMake
    {
        public void CreateAutoCar()
        {
            Console.WriteLine("生成红色小轿车");
        }
    }

    /// <summary>
    /// 蓝色小轿车
    /// </summary>
    public class _BuleCar : IAutoCarMake
    {
        public void CreateAutoCar()
        {
            Console.WriteLine("生成蓝色小轿车");
        }
    }

    /// <summary>
    /// 简单工厂模式-工厂类
    /// </summary>
    public class Factory
    {
        public IAutoCarMake CreateAutoCar(string flag)
        {
            switch (flag)
            {
                case "red":
                    return new _RedCar();
                case "blue":
                    return new _BuleCar();
            }
            return null;
        }
    }
}
