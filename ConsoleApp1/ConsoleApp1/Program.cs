using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            string str = Console.ReadLine();
            new Thread(() => { Summ(str); }).Start();
        }

        static void Summ(string str)
        {
            try
            {
                int num = Convert.ToInt32(str);
                Console.WriteLine(num);
                if (num > 0)
                {
                    int max = num;
                    for (int i = 0; i < max; i++)
                    {
                        num += i;
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Результат суммирования: {num}\n");
                }
                else if (num < 0)
                {
                    int min = num;
                    int j = 0;
                    for (int i = min; i < 0; i++)
                    {
                        num += i;
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Итог суммирования: {num}\n");
                }
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка! {e.Message}");
                Console.Read();
            }
        }
    }
}