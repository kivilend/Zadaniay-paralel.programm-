using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"1) id потока - {Thread.CurrentThread.ManagedThreadId}");

            List<int> array = new List<int>();

            for (int i = 1; i < 300; i++)
            {
                array.Add(i);
            }

            // параллельная обработка
            array.AsParallel().ForAll(x =>
            {
                double value = Math.Pow(x, 2);
                Console.WriteLine(
                    $"Число - {x}, \tвозводим в квадрат - {value}, \tтекущий поток - {Thread.CurrentThread.ManagedThreadId}");
            });

            Console.WriteLine($"Конец");
            Console.ReadLine();
        }
    }
}