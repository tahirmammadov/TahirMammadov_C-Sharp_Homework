/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

while ((n < 100 || n > 999) && (n > -100 || n < -999))
{
    Console.Write("Неправильное значение!\nВведите трехзначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int result = n % 100 / 10;
Console.WriteLine($"Результат: {result} вторая цифра числа {n}");
//Console.WriteLine(num/10%10);