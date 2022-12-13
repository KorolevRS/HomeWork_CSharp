/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
int m, n;
Console.Write($"Введите размерность m: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите размерность n: ");
int.TryParse(Console.ReadLine()!, out n);
double[,] array = new double[m, n];

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = (double)new Random().Next(100) / 10.0;
//vможно использовать new Random().NextDouble() - вещественные числа 0,0 до 1,0

PrintMassive(array);

void PrintMassive(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}