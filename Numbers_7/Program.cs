// Написать программу для нахождения результата из следующей задачи: пирожок в столовой стоит a рублей и b копеек. Вывести в консоль сколько рублей и копеек нужно заплатить за n пирожков. Данные вводятся с консоли построчно: a, b, n


using System;
namespace Numbers_7
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Введите целое число, обозначающие количество рублей ");
            int rubles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число, обозначающие количество копеек ");
            int kopecks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нужное количество пирожков ");
            int cntFood = Convert.ToInt32(Console.ReadLine());
            int onlyKopecks = (rubles * 100 + kopecks) * cntFood;
            Console.WriteLine(cntFood + " пирожков(ка) стоит " + onlyKopecks / 100 + " руб " + onlyKopecks % 100 + " коп" );
            Console.ReadKey();
        }
    }
}