using Unit;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var mail = new Mail("liuchaozhu@wine-world.com", "邮件测试", "这是一个邮件");
            mail.Send();
            System.Console.ReadLine();



        }
    }
}
