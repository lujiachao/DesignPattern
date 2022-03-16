using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class 迭代器模式
    {
        //抽象聚合
        public interface IAggregate
        {
            void Add(Object obj);
            void Remove(Object obj);
            IIterator GetIterator();
        }

        //具体聚合
        public class ConcreteAggregate : IAggregate
        {
            private List<Object> list = new List<Object>();
            public void Add(Object obj)
            {
                list.Add(obj);
            }
            public void Remove(Object obj)
            {
                list.Remove(obj);
            }
            public IIterator GetIterator()
            {
                return (new ConcreteIterator(list));
            }
        }

        //抽象迭代器
        public interface IIterator
        {
            Object First();
            Object Next();
            bool HasNext();
        }

        //具体迭代器
        public class ConcreteIterator : IIterator
        {
            private List<Object> list = null;
            private int index = -1;
            public ConcreteIterator(List<Object> list)
            {
                this.list = list;
            }
            public bool HasNext()
            {
                if (index < list.Count - 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public Object First()
            {
                index = 0;
                Object obj = list[index]; ;
                return obj;
            }
            public Object Next()
            {
                Object obj = null;
                if (this.HasNext())
                {
                    obj = list[++index];
                }
                return obj;
            }
        }
    }
}
