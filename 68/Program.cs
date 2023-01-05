/* Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

M = 28; N = 7 -> 7

*/

using System;

class Program
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            var t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Алгоритм Евклида");
        Console.Write("M = ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.Write("N = ");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Наибольший общий делитель чисел {0} и {1} равен {2}", a, b, GCD(a, b));
        Console.ReadLine();
    }
}