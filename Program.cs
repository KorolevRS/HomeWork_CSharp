/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
Работает только для квадратных матриц одного размера*/
int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] arrayResult = new int[array1.GetLength(0), array2.GetLength(1)];
FillArray(array1);
Print(array1);
Console.WriteLine();
FillArray(array2);
Print(array2);
Console.WriteLine();

for (int i = 0; i < arrayResult.GetLength(0); i++)
    for (int j = 0; j < arrayResult.GetLength(1); j++)
        arrayResult[i, j] = ProizvedenieElemetov(array1, array2, i, j);
Print(arrayResult);

void FillArray(int[,] arr)//заполнение массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }

    }
}
void Print(int[,] arr)//вывод массива
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

int ProizvedenieElemetov(int[,] arr1, int[,] arr2, int i, int j)
{
    int summa = 0;
    for (int k = 0; k < arr1.GetLength(0); k++)
        summa += arr1[i, k] * arr2[k, j];
    return summa;
}