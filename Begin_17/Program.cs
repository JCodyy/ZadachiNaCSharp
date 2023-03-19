using System;
namespace Begin_17
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите два числв для перестановки ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("Значения после перестановки " + number1 + " " + number2);
            Console.ReadKey();
        }
    }
}