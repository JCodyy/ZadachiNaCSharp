using System;
namespace Numbers_6
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите 2 числа ");
            int apples = Convert.ToInt32(Console.ReadLine());
            int students = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Остаток" + apples + "/" + students + " = " + (apples % students));
            Console.ReadKey();
        }
    }
}