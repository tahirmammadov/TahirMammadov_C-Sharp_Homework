// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write($"Введите любое число: ");
double num = Convert.ToDouble(Console.ReadLine());

if(num<0)
{
    num=-num;
}

if (num >= 100)
{
    for (int i = 0; num >= 1000; i++)
    {
        num /= 10;
    }
    Console.WriteLine($"Результат: {num % 10 - num%1}");
}
else if (num < 100)
{
    Console.WriteLine($"третьей цифры нет");
}