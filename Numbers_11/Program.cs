// Numbers_11
// Дано неотрицательное целое число. Найдите число десятков этого числа.


using System;
namespace Serg40in
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            Console.WriteLine("Число десятков = " + int.Parse(Console.ReadLine()) / 10 % 10);
            Console.ReadKey();
        }
    }
}