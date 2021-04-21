namespace test.Aop
{
    /// <summary>
    /// 测试类
    /// </summary>
    public class EchoImpl : IEcho
    {
        public string Echo(string message) => message;
    }
}
