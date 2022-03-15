using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Expression
    {
        //举个例子，在一所银行里，有几个级别的员工，柜员、主管、经理。如果有人来存款，柜员只能处理10000元以内的取款业务，超出了就只能传递给他的上级主管去处理。主管只能处理100000元的业务，超出了就只能传递给他的上级经理去处理 
        //抽象处理者
        public abstract class Handler
        {
            protected Handler nextHandler;

            //设置下一级处理人
            public void SetHandler(Handler handler)
            {
                this.nextHandler = handler;
            }

            public abstract void HandleRequest(decimal amount);
        }

        //柜员
        public class Teller : Handler
        {
            public override void HandleRequest(decimal amount)
            {
                if (amount < 10000)
                {
                    Console.WriteLine("柜员提取的金额：" + amount);
                }
                else if (this.nextHandler != null)
                {
                    Console.WriteLine("柜员无法处理,转主管");
                    nextHandler.HandleRequest(amount);
                }
            }
        }

        //主管
        public class Supervisor : Handler
        {
            public override void HandleRequest(decimal amount)
            {
                if (amount < 100000)
                {
                    Console.WriteLine("主管提取的金额：" + amount);
                }
                else if (this.nextHandler != null)
                {
                    Console.WriteLine("主管无法处理,转经理");
                    nextHandler.HandleRequest(amount);
                }
            }
        }

        //经理
        public class BankManager : Handler
        {
            public override void HandleRequest(decimal amount)
            {
                Console.WriteLine("银行经理提取的金额：" + amount);
            }
        }
    }
}
