using System.Linq.Expressions;

namespace DesignPattern
{
    public class Expression
    {
        public class DutyMain<T1> : BasicDuty<T1>
        {
        
        }

        public interface IDutyLinq { }

        public interface IDutyJoinLinq<T1> : IDutyLinq
        {
            IDutyJoinLinq<T1> DutyWhere(Expression<Func<T1, bool>> predicate);
        }

        public class BasicDuty<T1> : IDutyJoinLinq<T1>
        {
            public IDutyJoinLinq<T1> DutyWhere(Expression<Func<T1, bool>> predicate)
            {
                return null;
            }
        }
    }
}
