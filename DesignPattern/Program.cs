// See https://aka.ms/new-console-template for more information
using DesignPattern;
using static DesignPattern.AbstractFactoryPattern;
using static DesignPattern.FactoryCreator;
using static DesignPattern.Product;
using static DesignPattern.SingletonDesign;
using static DesignPattern.享元模式;
using static DesignPattern.命令模式;
using static DesignPattern.普通模板模式;
using static DesignPattern.桥接模式;
using static DesignPattern.状态模式;
using static DesignPattern.策略模式;
using static DesignPattern.组合模式;
using static DesignPattern.责任链;

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

// 代理模式
Proxy proxy = new Proxy();
proxy.Request();

// 双向适配器模式
Console.WriteLine("类适配器模式测试：");
ITwoWayTarget target = new TragetRealize();
ITwoWayAdaptee adaptee = new AdapteeRealize();
Console.WriteLine("目标通过双向适配器访问适配者：");
ITwoWayTarget twoWayTarget = new TwoWayAdapter(adaptee);
twoWayTarget.Request();
Console.WriteLine("-------------------");
Console.WriteLine("适配者通过双向适配器访问目标：");
ITwoWayAdaptee twoWayAdaptee = new TwoWayAdapter(target);
twoWayAdaptee.SpecificRequest();

// 桥接模式
ITmplementor imple  =  new ConcreteImplementorA();
Abstraction abs = new RefinedAbstraction(imple);
abs.Operation();

// 装饰模式
DesignPattern.IComponent p = new ComcreteComponent();
p.Operation();
DesignPattern.IComponent d = new ConcreteDecoratorA(p);
d.Operation();

// 外观模式
Facade f = new Facade();
f.method();

// 抽象外观模式
Facade1 f1 = new Facade1();
f1.Method1();
f1.Method2();
Facade2 f2 = new Facade2();
f2.Method1();
f2.Method2();

// 享元模式
FlyweightFactory factory = new FlyweightFactory();
IFlyWeight f01 = factory.GetFlyweight("a");
IFlyWeight f02 = factory.GetFlyweight("a");
IFlyWeight f03 = factory.GetFlyweight("a");
IFlyWeight f11 = factory.GetFlyweight("b");
IFlyWeight f12 = factory.GetFlyweight("b");

f01.Operation(new UnsharedConcreteFlyweight("第1次调用a。"));
f02.Operation(new UnsharedConcreteFlyweight("第2次调用a。"));
f03.Operation(new UnsharedConcreteFlyweight("第3次调用a。"));
f11.Operation(new UnsharedConcreteFlyweight("第1次调用b。"));
f12.Operation(new UnsharedConcreteFlyweight("第2次调用b。"));

// 组合模式
组合模式.IComponent c0 = new Composite();
组合模式.IComponent c1 = new Composite();
组合模式.IComponent leaf1 = new Leaf("1");
组合模式.IComponent leaf2 = new Leaf("2");
组合模式.IComponent leaf3 = new Leaf("3");
c0.Add(leaf1);
c0.Add(c1);
c1.Add(leaf2);
c1.Add(leaf3);
c0.Operation();

// 普通模板模式
AbstractTemplateClass tm = new ConcreteClass();
tm.TemplateMethod();

// 策略模式
Play play3 = new ThreeCodePlay(new List<string>() { "01005" }, 3, "00011");
PlayContext context3 = new PlayContext(play3);
context3.GetPrizeRate();

Play play4 = new FourCodePlay(new List<string>() { "01005" }, 3, "00011");
PlayContext context4 = new PlayContext(play4);
context4.GetPrizeRate();

// 命令模式
ICommand cmd = new ConcreteCommand(new Receiver());
Invoker ir = new Invoker(cmd);
Console.WriteLine("客户访问调用者的Call()方法...");
ir.Call();

// 责任链模式
Handler teller = new Teller(); //柜员
Handler supervisor = new Supervisor(); //主管
Handler bankManager = new BankManager(); //经理
teller.SetHandler(supervisor); //定义柜员上级为主管
supervisor.SetHandler(bankManager);//定义主管上级为经理
                                   //
Console.WriteLine("柜员处理不同金额的业务");
Console.WriteLine("客户存9000");
teller.HandleRequest(9000);
Console.WriteLine();
Console.WriteLine("客户存90000");
teller.HandleRequest(90000);
Console.WriteLine();
Console.WriteLine("客户存150000");
teller.HandleRequest(150000);
Console.WriteLine();

//
Console.WriteLine("柜员请假，业务都由主管处理");
Console.WriteLine("客户存9000");
supervisor.HandleRequest(9000);
Console.WriteLine();
Console.WriteLine("客户存90000");
supervisor.HandleRequest(90000);
Console.WriteLine();
Console.WriteLine("客户存150000");

// 状态模式
EnvironmentContext environmentContext = new EnvironmentContext();
environmentContext.Handle();
environmentContext.Handle();
environmentContext.Handle();
environmentContext.Handle();

Console.WriteLine("Hello, World!");
