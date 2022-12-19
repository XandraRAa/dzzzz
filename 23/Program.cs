/* Задача 23: Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.

2,3 -> 8, 27

1,5 -> 1, 8, 27, 64, 125
*/

using System;
class Task_1 {
  static void Main() {
    int n, m;
    
    Console.Write("N: ");
    n = Int32.Parse (Console.ReadLine());
    Console.Write("M: ");
    m = Int32.Parse (Console.ReadLine());
    
   { 
    Console.Write($"{n*n*n} ");
    Console.Write($"{m*m*m} ");
}
    
    for (int i = n; i <= m; i++) {
        Console.Write("{0} ", i);
    }
    

  }
}