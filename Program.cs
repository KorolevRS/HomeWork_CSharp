/*Задача 21.Напишите программу, которая принимает на вход координаты двух точек и
 находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

// int x1, y1, z1, x2, y2, z2;
// Console.Write($"Точка А. Введите координату x: ");
// int.TryParse(Console.ReadLine()!, out x1);
// Console.Write($"Точка А. Введите координату y: ");
// int.TryParse(Console.ReadLine()!, out y1);
// Console.Write($"Точка А. Введите координату z: ");
// int.TryParse(Console.ReadLine()!, out z1);
// Console.Write($"Точка B. Введите координату x: ");
// int.TryParse(Console.ReadLine()!, out x2);
// Console.Write($"Точка B. Введите координату y: ");
// int.TryParse(Console.ReadLine()!, out y2);
// Console.Write($"Точка B. Введите координату z: ");
// int.TryParse(Console.ReadLine()!, out z2);
// double rast = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
// Console.WriteLine($"Расстояние между точками А и В в 3D пространстве равно: \n {Math.Round(rast, 2)}");
double[] A = new double[] { 3, 6, 8 };
double[] B = new double[] { 2, 1, -7 };
double rast = Math.Sqrt((A[0] - B[0]) * (A[0] - B[0]) + (A[1] - B[1]) * (A[1] - B[1]) + (A[2] - B[2]) * (A[2] - B[2]));
Console.WriteLine($"Расстояние между точками А и В в 3D пространстве равно: \n {Math.Round(rast, 2)}");