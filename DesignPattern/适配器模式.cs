using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // 目标接口
    public interface ITwoWayTarget
    {
        void Request();
    }

    // 适配者接口
    public interface ITwoWayAdaptee
    {
        void SpecificRequest();
    }

    // 目标实现
    public class TragetRealize : ITwoWayTarget
    {
        public void Request()
        {
            Console.WriteLine("目标代码被调用!");
        }
    }

    // 适配者实现
    public class AdapteeRealize : ITwoWayAdaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("适配者代码被调用");
        }
    }

    // 双向适配器
    public class TwoWayAdapter : ITwoWayTarget, ITwoWayAdaptee
    {
        private ITwoWayTarget target;
        private ITwoWayAdaptee adaptee;
        public TwoWayAdapter(ITwoWayTarget target)
        { 
            this.target = target;
        }
        public TwoWayAdapter(ITwoWayAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public void Request()
        {
            adaptee.SpecificRequest();
        }

        public void SpecificRequest()
        {
            target.Request();
        }
    }
}
