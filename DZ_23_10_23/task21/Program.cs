/* Задача 21:
Напишите программу, которая принимает
на вход координаты двух точек и находит расстояние
между ними в 3D пространстве.

Пример:
A (3, 6, 8); B (2, 1, -7) ->15,84
A(7, -5, 0); B (1, -1, 9) -> 11,53
*/

// x1 = 3; y1 = 6; z1 = 8; x2 = 2; y2 = 1; z2 = -7 
Console.Write("Введите х1 : ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите у1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите х2 : ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите у2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

// d = distance (расстояние между 2 точками)
// AB = √(x1 - x2)2 + (y1 - y2)2 + (z1-z2)
// Math.Sqrt(25) = 5 - извлечение корня
// Math.Pow(число, степень) => Math.Pow(2, 3) => 2*2*2 = 8 - возв. в степень
double d = Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)) + (Math.Pow(z1 - z2, 2)));
// Math.Round(число, кол-во знаков): Math.Round(1.275, 2) => 1.27
Console.WriteLine($"d = {Math.Round(d, 2)}"); // d до 2 знаков
// $"Текст {переменная} текст"
// "\t" - табуляция, автоматически проставляет 4 пробела
Console.WriteLine($"d = {d:f2}"); // {имя:fкол-воз_наков}


