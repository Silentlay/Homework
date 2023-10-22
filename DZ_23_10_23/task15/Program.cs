/*Задача 15:
Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли
этот день выходным.
6 -> да
7 -> да
1 -> нет

*/

Console.Write("Введите номер дня недели: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
if (numberOfDay == 1) 
{
    Console.WriteLine("Понедельник");
}
else if (numberOfDay == 2)
{
    Console.WriteLine("Вторник");
}
else if (numberOfDay == 3)
{
    Console.WriteLine("Среда");
}
else if (numberOfDay == 4)
{
    Console.WriteLine("Четверг");
}
else if (numberOfDay == 5)
{
    Console.WriteLine("Пятница");
}
else if (numberOfDay == 6)
{
    Console.WriteLine("Суббота");
}
else if (numberOfDay == 7)
{
    Console.WriteLine("Вск");
}
else
{
    Console.WriteLine("Такого числа нет");
}

if (numberOfDay <= 5)
{
    Console.WriteLine("будний день");
}
else if (numberOfDay > 7)
{
    Console.WriteLine("Такого числа нет");
}
else
{
    Console.WriteLine("выходной день");
}
