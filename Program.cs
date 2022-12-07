/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i} элемент массива ");
    int.TryParse(Console.ReadLine()!, out array[i]);
}
// Console.Write($"[");
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();
// for (int i = 0; i < array.Length - 1; i++) \\участок кода чтобы вывести в формате [1, 2, 5, 7, 19]
//     Console.Write($"{array[i]}, ");
// Console.Write($"{array[array.Length - 1]}]\n");