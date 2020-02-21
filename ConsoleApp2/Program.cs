using System;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c, n;
            string z = "З початку доби пройшло:";
            n = Convert.ToInt32(Console.ReadLine());
            a = n / 3600;
            n -= (n / 3600) * 3600;
            b = n / 60;
            n -= (n / 60) * 60;
            c = n % 3600;
            Console.WriteLine($" {z} ");
            Console.WriteLine($"Годин: {a}  Хвилин: {b}  Секунд: {c}");
        }
    }
}