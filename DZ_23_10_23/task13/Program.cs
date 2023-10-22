/* Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 
*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    while (number >= 1000)
    {
        number /= 10;
    }
    int thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра в числе {number} = {thirdDigit}");
}
else
{
    Console.WriteLine("Число не лежит в интересующем нас диапазоне");
}