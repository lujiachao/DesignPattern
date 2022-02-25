﻿// See https://aka.ms/new-console-template for more information
using DesignPattern;
using static DesignPattern.AbstractFactoryPattern;
using static DesignPattern.FactoryCreator;
using static DesignPattern.Product;
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

// 工厂方法模式
FactoryCreator factoryCreator = new BlackCarFactoryMethod();
factoryCreator._AuthCar().CreatorCar();
factoryCreator = new OriangeFactoryMethod();
factoryCreator._AuthCar().CreatorCar();

// 抽象工厂模式
// 输出三星产品
AbstractFactorys samsung = new SamsungFactory();
Mobile _samsungMobile = samsung.Mobile();
Screen _samsungScreen = samsung.screen();
_samsungMobile.DisplayMobile();
_samsungScreen.DisplayScreen();
// 输出LG产品
AbstractFactorys lg = new LGFactory();
Mobile _lgMobile = lg.Mobile();
Screen _lgScreen = lg.screen();
_lgMobile.DisplayMobile();
_lgScreen.DisplayScreen();

// 客户找到电脑城老板说要买电脑，这里要装两台电脑
// 创建指挥者和构造者
var director = new Director();
Builder b1 = new ConcreteBuilder1();
Builder b2 = new ConcreteBuilder2();

// 老板叫员工b1去组装第一台电脑
director.Construct(b1);

// 组装完，组装人员搬来组装好的电脑
Computer computer1 = b1.GetComputer();
computer1.Show();

// 老板叫员工去组装第二台电脑
director.Construct(b2);
Computer computer2 = b2.GetComputer();
computer2.Show();

Console.WriteLine("Hello, World!");
