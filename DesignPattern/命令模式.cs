using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesignPattern
{
    public class 命令模式
    {
        // 调用者
        public class Invoker
        {
            private ICommand command;
            public Invoker(ICommand command)
            {
                this.command = command;
            }
            public void SetCommand(ICommand command)
            {
                this.command = command;
            }
            public void Call()
            {
                Console.WriteLine("调用者执行命令command...");
                command.Execute();
            }
        }

        //抽象命令
        public interface ICommand
        {
            void Execute();
        }

        //具体命令
        public class ConcreteCommand : ICommand
        {
            private Receiver Receiver;
            public ConcreteCommand(Receiver receiver)
            {
                Receiver = receiver;
            }
            public void Execute()
            {
                Receiver.Action();
            }
        }

        //接收者
        public class Receiver
        {
            public void Action()
            {
                Console.WriteLine("接收者的Action()方法被调用...");
            }
        }
    }
}
