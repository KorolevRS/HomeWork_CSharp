/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] array = new int[3];
int k = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
    if (array[i] % 2 == 0) k++;
}
Print(array);

Console.WriteLine($"\nВ массиве {k} четных числа");

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}