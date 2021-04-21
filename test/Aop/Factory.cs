using System;
using System.Reflection;

namespace test.Aop
{
    /// <summary>
    /// 运行类
    /// </summary>
    public  class Factory
    {
        public static void Run() {
            IEcho toWrap = new EchoImpl(); // 测试实例
            IEcho decorator = DispatchProxy.Create<IEcho, GenericDecorator>(); // 代理对象实例
            ((GenericDecorator)decorator).Wrapped = toWrap; // 代理对象中的测试实例
            ((GenericDecorator)decorator).Start = tm => Console.WriteLine($"{tm.Name} Before");
            ((GenericDecorator)decorator).End = tm => Console.WriteLine($"{tm.Name} End");
            decorator.Echo("Hello");
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           