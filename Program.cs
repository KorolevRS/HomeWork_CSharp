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
FillArray(array);
Print(array);

int strokaMinSumma = SummaStroki(array, 0);
int nomerStrokaMinSumma = 0;
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SummaStroki(array, i);
    if (temp < strokaMinSumma)
    {
        strokaMinSumma = temp;
        nomerStrokaMinSumma = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой: {nomerStrokaMinSumma + 1}");

void Print(int[,] arr) // выводит массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}
void FillArray(int[,] arr) //Заполнение массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(10);
}
int SummaStroki(int[,] arr, int k)// подсчеты суммы элементов в строке
{
    int SummaStroki = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
        SummaStroki += array[k, j];
    Console.Write($"{SummaStroki} ");//вывод суммы каждой строки
    return SummaStroki;
}