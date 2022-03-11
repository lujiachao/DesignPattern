using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class 享元模式
    {
        // 非享元角色
        public class UnsharedConcreteFlyweight
        {
            private String info;
            public UnsharedConcreteFlyweight(String info)
            {
                this.info = info;
            }
            public String GetInfo()
            {
                return info;
            }
            public void SetInfo(String info)
            {
                this.info = info;
            }
        }

        // 抽象享元角色
        public interface IFlyWeight
        {
            void Operation(UnsharedConcreteFlyweight state);
        }

        // 具体享元角色
        public class ConcreteFlyweight : IFlyWeight
        {
            public string key;
            public ConcreteFlyweight(string key)
            { 
                this.key = key;
                Console.WriteLine($"具体享元{key}被创建！");
            }

            public void Operation(UnsharedConcreteFlyweight outState)
            {
                Console.WriteLine("具体享元" + key + "被调用，");
                Console.WriteLine("非享元信息是:" + outState.GetInfo());
            }
        }

        // 享元工厂角色
        public class FlyweightFactory
        {
            private Dictionary<string, IFlyWeight> flyweights = new Dictionary<string, IFlyWeight>();
            public IFlyWeight GetFlyweight(string key)
            {
                IFlyWeight flyWeight;
                flyweights.TryGetValue(key, out flyWeight);
                if (flyWeight != null)
                {
                    Console.WriteLine("具体享元" + key + "已经存在，被成功获取！");
                }
                else
                {
                    flyWeight = new ConcreteFlyweight(key);
                    flyweights.Add(key, flyWeight);
                }
                return flyWeight;
            }
        }
    }
}
