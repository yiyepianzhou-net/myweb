using System;
using System.Reflection;

namespace test.Aop
{
    /// <summary>
    /// 通用装饰者
    /// </summary>
    public class GenericDecorator : DispatchProxy
    {
        public object Wrapped { get; set; }
        public Action<MethodInfo> Start { get; set; }
        public Action<MethodInfo> End { get; set; }
        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Start?.Invoke(targetMethod);
            object result = targetMethod.Invoke(Wrapped, args);
            Console.WriteLine(result);
            End?.Invoke(targetMethod);
            return result;
        }
    }
}
