// See https://aka.ms/new-console-template for more information
using DesignPattern;
using static DesignPattern.SingletonDesign;

// 单例模式
// 普通
var singleton = SingletonDesign.GetSingleton();
// 线程安全
var singleton1 = SingletonDesign1.GetThreadSafeSingleton();

// 工厂模式
IAutoCarMake parents = new Factory().CreateAutoCar("red");
parents.CreateAutoCar();
parents = new Factory().CreateAutoCar("blue");
parents.CreateAutoCar();
Console.WriteLine("Hello, World!");
