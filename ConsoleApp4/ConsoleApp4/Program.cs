using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Начало");

            var result = await MethodAsync(30);

            Console.WriteLine("Длинна масива - " + result.Length);

            foreach (var i in result)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine($"Конец");
            Console.Read();
        }

        // определение асинхронного метода
        static async Task<int[]> MethodAsync(int n)
        {
            Console.WriteLine($"2) id потока - {Thread.CurrentThread.ManagedThreadId}");

            return await Task.Run(() =>
            {
                Console.WriteLine($"3) id потока - {Thread.CurrentThread.ManagedThreadId}");

                var range = Enumerable.Range(0, n);
                return range.ToArray();
            });
        }
    }
}
