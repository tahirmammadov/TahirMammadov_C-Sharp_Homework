/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int n2= int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ое число: ");
int n3 = int.Parse(Console.ReadLine()!);

int max=n1;
if (max < n2){
    max = n2;
}
if (max < n3) {
    max = n3;
} 

if (max==n2 && max==n3){
    Console.WriteLine ($"Результат: все числа равны!");
} else {
    Console.WriteLine ($"Результат: {max} максимальное число");
}

