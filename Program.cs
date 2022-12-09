/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] array = new int[6];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000, 1000);
    if (i % 2 != 0) sum += array[i];//Первая нечетная позиция это array[1]
}
Print(array);

Console.WriteLine($"\nСумма элементов на нечетных позициях = {sum}");

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}