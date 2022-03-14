using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class 组合模式
    {
        // 抽象构建
        public interface IComponent
        {
            void Add(IComponent c);

            void Remove(IComponent c);

            IComponent GetChild(int i);

            void Operation();
        }

        // 树叶构件
        public class Leaf : IComponent
        {
            private string name;
            public Leaf(string name)
            {
                this.name = name;
            }
            public void Add(IComponent c) { }

            public void Remove(IComponent c) { }

            public IComponent GetChild(int i)
            {
                return null;
            }
            public void Operation()
            {
                Console.WriteLine("树叶" + name + "：被访问！");
            }
        }

        // 树枝构建
        public class Composite : IComponent
        {
            private List<IComponent> children = new List<IComponent>();
            public void Add(IComponent c)
            {
                children.Add(c);
            }
            public void Remove(IComponent c)
            {
                children.Remove(c);
            }
            public IComponent GetChild(int i)
            {
                return children[i];
            }
            public void Operation()
            {
                foreach (var obj in children)
                {
                    obj.Operation();
                }
            }
        }
    }
}
