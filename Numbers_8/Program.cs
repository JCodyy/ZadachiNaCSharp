// Написать программу для вычисления введенного число x в 6 степени при помощи трех операций умножения.


using System;
namespace Serg40in {
  class Program {
    static void Main(string[] args) {
    Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());
    int q = x * x;
    q = q * q * q;
    Console.Write(x + " в шестой степени = " + q);
    Console.ReadKey();
    } 
  }
}