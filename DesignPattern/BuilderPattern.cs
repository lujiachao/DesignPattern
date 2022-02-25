using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{

    public class Product
    {
        /// <summary>
        /// 小王和小李难道会自愿地去组装嘛，谁不想休息的，这必须有一个人叫他们去组装才会去的
        /// 这个人当然就是老板了，也就是建造者模式中的指挥者
        /// 指挥创建过程类
        /// </summary>
        public class Director
        {
            public void Construct(Builder builder)
            {
                builder.BuildPartCpu();
                builder.BuildPartMainBoard();
            }
        }

        /// <summary>
        /// 电脑类
        /// </summary>
        public class Computer
        {
            // 电脑组件集合
            private readonly IList<string> _parts = new List<string>();

            // 把单个组件添加到电脑组件集合中
            public void Add(string part)
            {
                _parts.Add(part);
            }

            public void Show()
            {
                Console.WriteLine("电脑开始在组装.......");
                foreach (string part in _parts)
                {
                    Console.WriteLine("组件" + part + "已装好");
                }

                Console.WriteLine("电脑组装好了");
            }
        }

        /// <summary>
        /// 抽象建造者，这个场景下为"组装人"，这里也可以定义为接口
        /// </summary>
        public abstract class Builder
        {
            // 装CPU
            public abstract void BuildPartCpu();

            // 装主板
            public abstract void BuildPartMainBoard();

            // 当然还有装硬盘，电源等组件，这里省略

            // 获得组装好的电脑
            public abstract Computer GetComputer();
        }

        /// <summary>
        /// 具体建造者，具体某个人为具体建造者，例如：装机小王
        /// </summary>
        public class ConcreteBuilder1 : Builder
        {

            readonly Computer _computer = new Computer();
            public override void BuildPartCpu()
            {
                _computer.Add("CPU1");
            }

            public override void BuildPartMainBoard()
            {
                _computer.Add("Main board1");
            }

            public override Computer GetComputer()
            {
                return _computer;
            }
        }

        /// <summary>
        /// 具体创建者，具体的某个人为具体创建者，例如：装机小李啊
        /// 又装另一台电脑了
        public class ConcreteBuilder2 : Builder
        {
            readonly Computer _computer = new Computer();
            public override void BuildPartCpu()
            {
                _computer.Add("CPU2");
            }

            public override void BuildPartMainBoard()
            {
                _computer.Add("Main board2");
            }

            public override Computer GetComputer()
            {
                return _computer;
            }
        }

    }
}
