// ЗАДАЧА №1138		
// Второй максимум
// (Время: 1 сек. Память: 16 Мб Сложность: 16%)

// Задана последовательность натуральных чисел, завершающаяся числом 0.
//Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, 
//если из последовательности удалить наибольший элемент.

// Входные данные
// Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. 
//Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума.

// Примеры
// №	INPUT.TXT	                    OUTPUT.TXT
// 1	1 7 9 0	                            7
// 2	1 2 3 4 5 6 7 0 8 9 10	            6


//1-st option (цикл)
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int max = num;
int max2 = 0;

while(num != 0)
{
    num = Convert.ToInt32(Console.ReadLine());
    int temp = 0;
    if (max < num)
    {
        temp = max;
        max = num;
        max2 = temp;
    }
    else if (max2 < num)
    {
        max2 = num;
    }
}

Console.WriteLine();
Console.WriteLine($"Первый максимум = {max}");
Console.WriteLine($"Второй максимум = {max2}");

//2-nd option (массив)
// Console.Clear();
// int[] numbers = new int[100];
// int max = 0;

// for (int i = 0; i < 50; i++)
// {
//     numbers[i] = new Random().Next(1,1000);
// }

// numbers[50] = 0;

// for (int i = 51; i < 100; i++)
// {
//     numbers[i] = new Random().Next(1,100);
// }

// for (int i = 0; i < 100; i++)
// {
//     Console.WriteLine($"{i} - {numbers[i]}");
// }

// for (int i = 0; numbers[i] != 0; i++)
// {
//     if(max < numbers[i])
//     {
//         max = numbers[i];
//     }
// }

// Console.WriteLine($"Первый максимум: {max}");

// for (int i = 0; i < numbers.Length; i++)
// {
//     if(numbers[i] == max)
//     {
//         numbers[i] = 1;
//     }
// }

// max = numbers[0];

// for (int i = 0; numbers[i] != 0; i++)
// {
//     if(max < numbers[i])
//     {
//         max = numbers[i];
//     }
// }

// Console.WriteLine($"Второй максимум: {max}");
