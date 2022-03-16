using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class ObserverStudy
    {
        public class WeatherData
        {
            /// <summary>
            /// 气温
            /// </summary>
            public string temperature { get; set; }
            /// <summary>
            /// 湿度
            /// </summary>
            public string humility { get; set; }
            /// <summary>
            /// 气压
            /// </summary>
            public string pressure { get; set; }
        }

        public class WeatherDataPublisher : IObservable<WeatherData>
        {
            List<IObserver<WeatherData>> observers = new List<IObserver<WeatherData>>();
            /// <summary>
            /// 订阅主题，将观察者添加到列表中
            /// </summary>
            /// <param name="observer"></param>
            /// <returns></returns>
            public IDisposable Subscribe(IObserver<WeatherData> observer)
            {
                observers.Add(observer);
                return new Unsubscribe(this.observers, observer);
            }
            /// <summary>
            /// 取消订阅类
            /// </summary>
            private class Unsubscribe : IDisposable
            {
                List<IObserver<WeatherData>> observers;
                IObserver<WeatherData> observer;
                public Unsubscribe(List<IObserver<WeatherData>> observers
                , IObserver<WeatherData> observer)
                {
                    this.observer = observer;
                    this.observers = observers;
                }

                public void Dispose()
                {
                    if (this.observers != null)
                    {
                        this.observers.Remove(observer);
                    }
                }
            }
            /// <summary>
            /// 通知已订阅的观察者
            /// </summary>
            /// <param name="weatherData"></param>
            private void Notify(WeatherData weatherData)
            {
                foreach (var observer in observers)
                {
                    observer.OnNext(weatherData);
                }
            }
            /// <summary>
            /// 接收最新的天气数据
            /// </summary>
            /// <param name="weatherData"></param>
            public void ReciveNewData(WeatherData weatherData)
            {
                Notify(weatherData);
            }
        }

        public abstract class WeatherDisplayBase : IObserver<WeatherData>
        {
            public virtual void OnCompleted()
            {
            }
            public virtual void OnError(Exception error)
            {
            }
            public abstract void OnNext(WeatherData value);
        }

        public class CurrentConditionDisplay : WeatherDisplayBase
        {
            public override void OnNext(WeatherData value)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("当前天气状况板");
                Console.WriteLine(string.Format("温度：{0}\n湿度：{1}\n气压：{2}",
                    value.temperature, value.humility, value.pressure));
            }
        }

        public class StatisticsConditionDisplay : WeatherDisplayBase
        {
            List<float> temperatures = new List<float>();
            public override void OnNext(WeatherData value)
            {
                float temperature;
                if (float.TryParse(value.temperature, out temperature))
                {
                    temperatures.Add(temperature);
                }
                Console.WriteLine("------------------");
                Console.WriteLine("温度统计板");
                Console.WriteLine(string.Format("平均温度：{0}\n最高温度：{1}\n最低温度：{2}",
                    temperatures.Average(), temperatures.Max(), temperatures.Min()));
            }
        }
    }
}
