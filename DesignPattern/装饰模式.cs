using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // 抽象构件角色
    public interface IComponent
    {
        void Operation();
    }

    // 具体构建角色
    public class ComcreteComponent : IComponent
    {
        public ComcreteComponent()
        {
            Console.WriteLine("创建具体构件角色");
        }
        public void Operation()
        {
            Console.WriteLine("调用具体构件角色的方法Operation()");
        }
    }

    //抽象装饰角色
    public abstract class Decorator : IComponent
    {
        private IComponent component;
        public Decorator(IComponent component)
        {
            this.component = component;
        }
        public virtual void Operation()
        {
            component.Operation();
        }
    }

    //具体装饰角色
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component)
            : base(component)
        {

        }
        public override void Operation()
        {
            base.Operation();
            AddedFunction();
        }
        public void AddedFunction()
        {
            Console.WriteLine("为具体构件角色增加额外的功能AddedFunction()");
        }
    }
}
