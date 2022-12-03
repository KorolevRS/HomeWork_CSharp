//Задача 8. Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int n;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out n);
int index = 0;
if (n <= 0)
{
    Console.Write($"Вы ввели число не из задания (менее 1) \n");
}
else
{
    /*for(int index = 1; index <= n; index++)
    {
        if (index %2==0)
        Console.Write($"{index} \n");
    }*/
   while (index < n) 
    {
	    index = index + 2;
        Console.Write($"{index} \n");
    }
}