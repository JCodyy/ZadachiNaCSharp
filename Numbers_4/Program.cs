using System;
namespace BeNumbers_4
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите три числа ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма = " + (number1  + number2 + number3) + " Произведение = " + (number1 * number2 * number3));
            Console.ReadKey();
        }
    }
}