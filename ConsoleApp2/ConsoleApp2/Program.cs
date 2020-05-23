using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Task3().Run();
        }
    }
    public class Task3
    {
        public void Run()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            new Task(() => {

                while (!token.IsCancellationRequested)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("Ожидание!");
                }
            }).Start();
            Thread.Sleep(1000);
            tokenSource.Cancel();

        }
    }
}
