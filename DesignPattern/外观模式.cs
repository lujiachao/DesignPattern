using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Facade
    {
        private SubSystem01 obj1 = new SubSystem01();
        private SubSystem02 obj2 = new SubSystem02();
        private SubSystem03 obj3 = new SubSystem03();
        public void method()
        {
            obj1.Method1();
            obj2.Method2();
            obj3.Method3(); 
        }

    }

    //子系统角色
    public class SubSystem01
    {
        public void Method1()
        {
            Console.WriteLine("子系统01的Method1()被调用！");
        }
    }

    //子系统角色
    public class SubSystem02
    {
        public void Method2()
        {
            Console.WriteLine("子系统02的Method2()被调用！");
        }
    }

    //子系统角色
    public class SubSystem03
    {
        public void Method3()
        {
            Console.WriteLine("子系统03的Method3()被调用！");
        }
    }
}
