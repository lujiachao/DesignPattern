using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    [Serializable]  //深克隆时需要将类标记为Serializable
    public class Person : ICloneable
    {
        public string CurrentEmployee { get; set; }
        public Member Member { get; set; }

        public Person()
        {
            this.CurrentEmployee = "admin";
            Member member = new Member();
            member.Id = 3;
            member.Name = "Mem";
            this.Member = member;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #region 静态方式创建对象
        private static Person _person;
        /// <summary>
        /// 静态构造函数，永远只运行一次
        /// </summary>
        static Person()
        {
            _person = new Person();
        }
        public static Person StaticClone()
        {
            return _person.MemberwiseClone() as Person;
        }
        #endregion
    }

    [Serializable]
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
