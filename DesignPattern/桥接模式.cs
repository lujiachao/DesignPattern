using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class 桥接模式
    {
        // 实现化角色
        public interface ITmplementor
        {
            void OperationImpl();
        }

        //具体实现化角色A
        public class ConcreteImplementorA : ITmplementor
        {
            public void OperationImpl()
            {
                Console.WriteLine("具体实现化(Concrete Implementor)角色A被访问");
            }
        }

        //抽象化角色
        public abstract class Abstraction
        {
            protected ITmplementor imple;
            protected Abstraction(ITmplementor imple)
            {
                this.imple = imple;
            }
            public abstract void Operation();
        }

        //扩展抽象化角色
        public class RefinedAbstraction : Abstraction
        {
            public RefinedAbstraction(ITmplementor imple) : base(imple)
            {

            }
            public override void Operation()
            {
                Console.WriteLine("扩展抽象化(Refined Abstraction)角色被访问");
                imple.OperationImpl();
            }
        }
    }
}
