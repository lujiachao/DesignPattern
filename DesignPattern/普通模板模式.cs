using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class 普通模板模式
    {
        public abstract class AbstractTemplateClass
        {
            public void TemplateMethod()
            {
                SpecificMethod();
                AbstractMethod1();
                AbstractMethod2();
            }

            public void SpecificMethod()
            {
                Console.WriteLine("抽象类中的具体方法被调用...");
            }
            public abstract void AbstractMethod1(); //抽象方法1
            public abstract void AbstractMethod2(); //抽象方法2
        }

        // 具体子类
        public class ConcreteClass : AbstractTemplateClass
        {
            public override void AbstractMethod1()
            {
                Console.WriteLine("抽象方法1的实现被调用...");
            }
            public override void AbstractMethod2()
            {
                Console.WriteLine("抽象方法2的实现被调用...");
            }
        }
    }
}
