/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
    Console.WriteLine($"Результат: {n1} большее, а {n2} меньшее число");
else if (n1 < n2)
    Console.WriteLine($"Результат: {n2} большее, а {n1} меньшее число");
else
    Console.WriteLine($"Результат: {n1} и {n2} равные числа");

