using System.Threading.Tasks;


namespace test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var task1 = Print();
            var task2 = Wait();
            await task1;
            await task2;

        }

        private static async Task Print()
        {
            System.Console.WriteLine("print 等待");
            await Task.Delay(2000);
            System.Console.WriteLine("print 结束");
        }


        private static async Task Wait()
        {

            System.Console.WriteLine("等待2s 开始");
            await Task.Delay(2000);
            System.Console.WriteLine("等待2s 结束");
        }
    }
}
