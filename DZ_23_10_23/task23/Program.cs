﻿/* Напишите программу, которая принимает на
вход число (N) и выдает таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число: "); // Выводим приглашение пользователю ввести число
int N = Convert.ToInt32(Console.ReadLine()); // Считываем введенное пользователем значение и конвертируем его в целое число
for (int start = 1; start <= N; start++) // Цикл, который выводит таблицу кубов чисел от 1 до N
{
    Console.Write($"{Math.Pow(start, 3)}\t"); // Вычисляем куб числа start с помощью метода Math.Pow и выводим результат в консоль
}

