using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class 策略模式
    {
        public abstract class Play
        {
            /// <summary>
            /// 中奖号码
            /// </summary>
            public List<string> PrizeNums { set; get; }

            /// <summary>
            /// 几期方案
            /// </summary>
            public int PeriodScheme { set; get; }

            /// <summary>
            /// 选择的位数，比如选中个位和十位
            /// </summary>
            public string ChoosePositions { set; get; }

            public Play(List<string> prizeNums, int period, string choosePositions)
            {
                this.PrizeNums = prizeNums;
                this.PeriodScheme = period;
                this.ChoosePositions = choosePositions;
            }
            public abstract Dictionary<string, double> ComputePrizeRate();
        }

        public class ThreeCodePlay : Play
        {
            public ThreeCodePlay(List<string> prizeNums, int period, string choosePositions) : base(prizeNums, period, choosePositions)
            {

            }

            public override Dictionary<string, double> ComputePrizeRate()
            {
                var rates = new Dictionary<string, double>();
                //获取三码的所有数 (0,1,2)-(7,8,9)
                Console.WriteLine("返回三码所有中奖率");
                //计算中奖率
                return rates;
            }
        }

        public class FourCodePlay : Play
        {
            public FourCodePlay(List<string> prizeNums, int period, string choosePositions) : base(prizeNums, period, choosePositions)
            {

            }

            public override Dictionary<string, double> ComputePrizeRate()
            {
                var rates = new Dictionary<string, double>();
                //获取四码的所有数 (0,1,2)-(7,8,9)
                Console.WriteLine("返回四码所有中奖率");
                //计算中奖率
                return rates;
            }
        }

        public class PlayContext
        {
            private Play play;

            public PlayContext(Play play)
            {
                this.play = play;
            }

            public Dictionary<string, double> GetPrizeRate()
            {
                return play.ComputePrizeRate();
            }
        }
    }
}
