﻿Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
    Console.WriteLine($"max = {b}");
else if (a == b)
    Console.WriteLine("Числа равны");
else
    Console.WriteLine($"max = {a}");
