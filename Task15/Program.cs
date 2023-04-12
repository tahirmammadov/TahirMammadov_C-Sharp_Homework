// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write($"Введите цифру от 1-го до 7-ми: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 1 || num > 7)
{
    Console.Write($"неправильное значение!\nВведите цифру от 1-го до 7-ми: ");
    num = Convert.ToInt32(Console.ReadLine());
}

//1-st option (if)
if(num == 6 || num == 7)
{
    Console.WriteLine($"да, выходной день");
}
else
{
    Console.WriteLine($"нет");
}

//2-nd option (switch)
// switch (num)
// {
//     case 6:
//     Console.WriteLine("да, выходной день");
//     break;

//     case 7:
//     Console.WriteLine("да, выходной день");
//     break;

//     default:
//     Console.WriteLine("нет");
//     break;
// }