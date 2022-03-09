using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // 抽象表达式类
    public interface IAbstractExpression
    {
        Object Interpret(String info);
    }

    // 终结符表达式类
    public class TerminalExpression : IAbstractExpression
    {
        public object Interpret(string info)
        {
            //对终结符表达式的处理
            return null;
        }
    }

    // 非终结符表达式类
    public class NonterminalExpression : IAbstractExpression
    {
        private IAbstractExpression exp1;
        private IAbstractExpression exp2;
        public Object Interpret(String info)
        {
            //非对终结符表达式的处理
            return null;
        }
    }

    // 环境类
    public class Context
    {
        private IAbstractExpression exp;
        public Context() {
            //数据初始化
        }

        public void Operation(String info)
        {
            //调用相关表达式类的解释方法
        }
    }
}
