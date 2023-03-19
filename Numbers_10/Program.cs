// Numbers_10
// Дано натуральное число, выведите его последнюю цифру


using System;
namespace Numbers_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            Console.Write("Последняя цифра = " + int.Parse(Console.ReadLine()) % 10);
            Console.ReadKey();
        }
    }
}