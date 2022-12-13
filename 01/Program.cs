//Задача 0
/*Console.Clear();
int square = 0;
Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());
square = n*n;
Console.WriteLine("Квадрат числа равен: " + square);*/

//Задача 1
/*Console.Clear();
Console.Write("Введите первое число: ");
int square = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: "); 
int n = Convert.ToInt32(Console.ReadLine());
if (square/n == n)
    Console.WriteLine("Число 1 является квадратом числа 2");
else
    Console.WriteLine("Число 1 не является квадратом числа 2");*/


//Задача 3
/*Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите номер дня недели: ");
}
if (n == 1)
    Console.WriteLine("Понедельник");
else if (n == 2)
    Console.WriteLine("Вторник");
else if (n == 3)
    Console.WriteLine("Среда");
else if (n == 4)
    Console.WriteLine("Четверг");
else if (n == 5)
    Console.WriteLine("Пятница");
else if (n == 6)
    Console.WriteLine("Суббота");
if (n == 7)
    Console.WriteLine("Воскресенье");*/

//Задача 5
/*Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = (-1) * n;;
for (int i = (-1) * n; i <= n; i++)
    Console.Write($"{i} ");
while (i < n)
{
    Console.Write($"{i} ");
    i++;
}*/

//Задача 7
/*Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(n % 10);*/

//Задача 10
/*Console.Clear();

int n = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);*/

//Задача 11
/*Console.Clear();

int n = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 100;
int n2 = n % 10;
Console.WriteLine(n1*10+n2);*/

//
/*Console.Clear();
string? s = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(s[0].ToString()));*/

//Задача 12
/*Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b != 0)
    Console.WriteLine($"не кратно, остаток {a%b}");
else
    Console.WriteLine("кратно");*/

//Задача 14
/*Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
    Console.WriteLine("Число кратно 7 и 23");
else
    Console.WriteLine("Число не кратно 7 и 23 одновременно");*/

//Задача 16
/*Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a*a==b || b*b==a )
    Console.WriteLine("да");
else
    Console.WriteLine("нет");*/

//Задача 17
/*Console.Clear();
Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

while (x == 0)
{
    Console.WriteLine("Вы ошиблись! \nВведите координату X: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
    Console.WriteLine("Вы ошиблись! \nВведите координату Y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");*/

//Задача 18
/*Console.Clear();
Console.Write("Введите номер четверти: ");
int chetvert = Convert.ToInt32(Console.ReadLine());
while (chetvert < 1 || chetvert > 4)
{
    Console.WriteLine("Вы ошиблись! \nВведите номер четверти: ");
    chetvert = Convert.ToInt32(Console.ReadLine());
}
if (chetvert == 1 || chetvert == 2)
    Console.WriteLine("y > 0");
else 
    Console.WriteLine("y < 0");
if (chetvert == 1 || chetvert == 4)
    Console.WriteLine("x > 0");
else 
    Console.WriteLine("x < 0");*/

//Задача 20
/*Console.Clear();
Console.Write("Введите координату X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
Console.WriteLine($"Расстояние между точками: {l}");*/

//Задача 22
/*Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= a; i++)
    Console.Write($"{Math.Pow(i, 2)} ");*/


//Методы - это обънетно-ориентированное программирование

//Массивы
//Целые числа

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(1, 11); // Заполняет числами от 1 до 10, 11 не входит в диапозон заполнения
// Console.WriteLine($"[{string.Join(", ", array)}]"); // Выводит наш массив через запятую в одну строку (Join)

//Дробные числа

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().NextDouble(); // Генерирует дробную часть от 0 да 1
// Console.WriteLine($"[{string.Join(", ", array)}]");

//Дробные с целой частью

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// for (int i = 0; i < array.Length; i++)
// {
//                                             // * (end - begin) + begin
// array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2); // Целая часть от 10 до 50
// }
// Console.WriteLine($"[{string.Join(", ", array)}]");


//Функции
// Необходимо вывести наибольшее число из 2-х

// char test(int a, int b)
// {
// if (a > b)
// return '>';
// return '<';
// }

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(test(n, m));
// // 1. return
// // * Возвращает аргумент туда, где была вызвана функция
// // * Завершает работу функции
// // * Возвращаемое значение необходимо принимать в консоль(вывод) или в переменную нужного типа данных
// // * Сколько аргументов мы принимаем, столько и передаем

//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 
// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine((1 + n) / 2 * n); // Через формулу геометрической прогрессии Sn=((A1+An)/2)*n

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (n > 0)
// {
//     count++;
//     n /= 10;
// }
// Console.WriteLine(count);

//Задача 28: Найти чему равен факториал числа
//
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 2; i <= n; i++)
// {
//     result = result * i;
// }
// Console.WriteLine($"Факториал числа равен {result}");

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// //
// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(0, 2);
// }
// Console.WriteLine($"[{string.Join(", ", array)}]");

// //Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
//
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }
// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] *= (-1);
// }
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");



// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да
// //
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }
// string ReleaseArray(int[] array, int k)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == k)
//             return "yes";
//     }
//     return "no";
// }
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Введите число: ");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ReleaseArray(array, k));

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101); // [-100, 100]
// }
// int ReleaseArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//             count++; // count = count + 1;
//     }
//     return count;
// }
// Console.Clear();
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine(ReleaseArray(array));


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
//
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11); // [1, 10]
// }
// int[] ReleaseArray(int[] array)
// {
//     int[] result = new int[array.Length / 2 + array.Length % 2];
//     for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//         result[i] = array[i] * array[array.Length - 1 - i];
//     return result;
// }
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Конечный массив: [{string.Join(", ", ReleaseArray(array))}]");
