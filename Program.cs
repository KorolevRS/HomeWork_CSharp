/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
int k1, k2, b1, b2;
Console.WriteLine($"Введите коэфициенты для прямых: b1, k1, b2, k2");
string[] ratioS = Console.ReadLine()!.Split(',');

int.TryParse(ratioS[0], out b1);
int.TryParse(ratioS[1], out k1);
int.TryParse(ratioS[2], out b2);
int.TryParse(ratioS[3], out k2);
if (k1 == k2)
    Console.WriteLine($"Прямые не пересекаются.");
else
    Console.WriteLine($"Две прямые с коэффициентами b1={b1}, k1={k1}, b1={b2}, k2={k2} пересекутся в точке с координатами {(double)(b2 - b1) / (k1 - k2)}, {(double)k1 * (b2 - b1) / (k1 - k2) + b1}");
