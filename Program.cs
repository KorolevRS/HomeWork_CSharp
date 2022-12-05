/*Задача12. Напишите программу,
 которая будет принимать на вход два числа
 и выводить, является ли второе число кратным
 первому. Если второе число не кратно
 числу первому, то программа выводит
 остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/

int a, b;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b);
if (a % b == 0)
    Console.WriteLine($"Кратно");
else
    Console.WriteLine($"Не кратно, остаток {a % b}");
