﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int result=n1%100/10;
Console.WriteLine($"Результат: {result} вторая цифра числа {n1}");