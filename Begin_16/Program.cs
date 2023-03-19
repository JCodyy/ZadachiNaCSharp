using System;
namespace Begin_16
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите целое число от 1 до 100 ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадрат числа = " + number * number);
            Console.ReadKey();
        }
    }
}