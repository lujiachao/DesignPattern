using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// 抽象外观模式
    /// </summary>
    public interface  IAbstractFacade
    {
        public void Method1();

        public void Method2();
    }

    /// <summary>
    /// 具体外观1
    /// </summary>
    public class Facade1 : IAbstractFacade
    {
        SubSystemAb01 obj1 = new SubSystemAb01();
        SubSystemAb02 obj2 = new SubSystemAb02();
        SubSystemAb03 obj3 = new SubSystemAb03();
        SubSystemAb04 obj4 = new SubSystemAb04();
        public void Method1()
        {
            obj1.Method1("Facade1");
            obj2.Method2("Facade1");
        }

        public void Method2()
        {
            obj3.Method3("Facade1");
            obj4.Method4("Facade1");
        }
    }

    /// <summary>
    /// 具体外观2
    /// </summary>
    public class Facade2 : IAbstractFacade
    {
        SubSystemAb01 obj1 = new SubSystemAb01();
        SubSystemAb02 obj2 = new SubSystemAb02();
        SubSystemAb03 obj3 = new SubSystemAb03();
        SubSystemAb04 obj4 = new SubSystemAb04();
        public void Method1()
        {
            obj1.Method1("Facade2");
            obj2.Method2("Facade2");
        }

        public void Method2()
        {
            obj3.Method3("Facade2");
            obj4.Method4("Facade2");
        }
    }

    //子系统角色
    public class SubSystemAb01
    {
        public void Method1(string faceName)
        {
            Console.WriteLine($"{faceName}子系统01的Method1()被调用！");
        }
    }

    //子系统角色
    public class SubSystemAb02
    {
        public void Method2(string faceName)
        {
            Console.WriteLine($"{faceName}子系统02的Method2()被调用！");
        }
    }

    //子系统角色
    public class SubSystemAb03
    {
        public void Method3(string faceName)
        {
            Console.WriteLine($"{faceName}子系统03的Method3()被调用！");
        }
    }

    //子系统角色
    public class SubSystemAb04
    {
        public void Method4(string faceName)
        {
            Console.WriteLine($"{faceName}子系统04的Method4()被调用！");
        }
    }
}
