/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] array = new int[4, 4];
int temp = array.GetLength(0) * array.GetLength(1);
int k = 1;
int i = 0;
int j = 0;
while (k <= temp)
{
    array[i, j] = k;
    k++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}

Print(array);



void Print(int[,] arr)// Вывод массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}