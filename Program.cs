/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"{a} -> ");

if ((a/100)!=0) 
    Console.WriteLine((a/100)%10);
else 
    Console.WriteLine($"третьей цифры нет");
