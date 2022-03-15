using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class 状态模式
    {
        //环境类
        public class EnvironmentContext
        {
            private State state;
            //定义环境类的初始状态
            public EnvironmentContext()
            {
                this.state = new ConcreteStateA();
            }
            //设置新状态
            public void SetState(State state)
            {
                this.state = state;
            }
            //读取状态
            public State GetState()
            {
                return (state);
            }
            //对请求做处理
            public void Handle()
            {
                state.Handle(this);
            }
        }

        // 抽象状态类
        public abstract class State
        {
            public abstract void Handle(EnvironmentContext context);
        }

        // 具体状态A类
        public class ConcreteStateA : State
        {
            public override void Handle(EnvironmentContext context)
            {
                Console.WriteLine("当前状态是A.");
                context.SetState(new ConcreteStateB());
            }
        }

        //具体状态B类
        public class ConcreteStateB : State
        {
            public override void Handle(EnvironmentContext context)
            {
                Console.WriteLine("当前状态是 B.");
                context.SetState(new ConcreteStateA());
            }
        }
    }
}
