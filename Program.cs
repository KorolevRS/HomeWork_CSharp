/*Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] array = new double[6];
//double[] array = new double[6] { 5, 5.6, 9, 8, 1.2, 45 }; так мы объявим массив в явном виде
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100) / 10.0;
// array[i] = new Random().Next(-100, 100);

double min = array[0];
double max = array[0];
Print(array);
MinMax(array);
Console.WriteLine($"\nРазница максимального ({max}) и минимального ({min}) значения = {max - min}");

void MinMax(double[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] >= max) max = arr1[i];
        else if ((arr1[i] < min)) min = arr1[i];
    }
}

void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}