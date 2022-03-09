using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // 抽象主题
    public interface ISubject
    {
        void Request();
    }

    // 真实主题
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("访问真实主题方法...");
        }
    }

    // 代理
    public class Proxy : ISubject
    {
        private RealSubject realSubject;

        public void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            PreRequest();
            realSubject.Request();
            PostRequest();
        }

        public void PreRequest()
        {
            Console.WriteLine("访问真实主题之前的预处理。");
        }

        public void PostRequest()
        {
            Console.WriteLine("访问真实主题之后的后续处理。");
        }
    }
}
