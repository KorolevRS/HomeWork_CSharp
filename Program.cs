/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
Console.Write($"Введите номер элемента массива в формате x,y: ");
string[] vvodEl = Console.ReadLine()!.Split(',');
int x, y;
int.TryParse(vvodEl[0], out x);
int.TryParse(vvodEl[1], out y);
int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(0, 11);

Print(array);

if (x <= array.GetLength(0) && y <= array.GetLength(1)) Console.WriteLine($"{array[x - 1, y - 1]}");
else Console.WriteLine($"Элемента с номером ({x},{y}) отсутствует");

void Print(int[,] arr)
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