/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
int[,,] array = new int[2, 2, 2];
int[] nums = new int[90];
for (int i = 0; i < 90; i++)
    nums[i] = i + 10;

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int temp = new Random().Next(90);
            while (nums[temp] == 0)
                temp = new Random().Next(90);
            array[i, j, k] = nums[temp];
            nums[temp] = 0;
        }

Print(array);
Console.WriteLine();


void Print(int[,,] arr)//вывод массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
}
