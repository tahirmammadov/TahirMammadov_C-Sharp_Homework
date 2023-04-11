/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

//1-st option (loop)
Console.Clear();
Console.Write("Введите число: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Все четные числа от 1 до {n1}:  ");

for (int i=1; i<=n1; i++){

    if(i%2 == 0){
        Console.Write($"{i} ");
    }

}
Console.WriteLine();

//2-nd option (recursion)
// Console.Clear();
// Console.Write("write a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// void EvenNum(int number)
// {
//     if (number > 0)
//     {
//         if (number % 2 == 0)
//         {
//             Console.Write($"{number}_");
//         }
//         EvenNum(number - 1);
//     }
// }

// EvenNum(num);
// Console.WriteLine();
