﻿Console.Clear();
Console.Write("Введите через запятую координаты вершин (x1, y1, x2, y2, x3, y3): ");
double[] array = Console.ReadLine().Split(",").Select(x => double.Parse(x)).ToArray();

double AB = Math.Sqrt(Math.Pow(array[0] - array[2], 2) + Math.Pow(array[1] - array[3], 2));
double BC = Math.Sqrt(Math.Pow(array[2] - array[4], 2) + Math.Pow(array[3] - array[5], 2));
double CA = Math.Sqrt(Math.Pow(array[0] - array[4], 2) + Math.Pow(array[1] - array[5], 2));;
double p = (AB + BC + CA) / 2;
double s = Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
Console.WriteLine($"Площадь треугольника: {Math.Round(s, 2)}");
