/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] array = new int[5, 4];

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(10);

Print(array);

int strokaMinSumm = 0;
int sumMin = 0;
for (int j = 0; j < array.GetLength(1); j++)
    sumMin += array[0, j];

for (int i = 0; i < array.GetLength(0); i++)
{
    int sumStr = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumStr += array[i, j];
    }
    if (sumStr < sumMin) strokaMinSumm = i;
}
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой: {strokaMinSumm + 1}");

void Print(int[,] arr) // выводит массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}