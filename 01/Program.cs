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

// int[] s =Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); //в одну строчку через пробел
// foreach (int element in s) // пройтись по всему массиву без привязки к номеру элемента

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11); // [1, 10]
// }
// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int tmp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = tmp;
//     }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

//Задача 40
// Console.Clear();
// Console.Write("Введите 1-ю длину: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ю длину: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-ю длину: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a + b > c && a + c > b && b + c > a)
//     Console.Write("Такой треугольник существует");
// else
//     Console.Write("Такой треугольник не существует");

//Задача 42
// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// string b = string.Empty;
// while (a > 0)
// {
//     b = Convert.ToString(a % 2) + b;
//     a /= 2;
// }
// Console.WriteLine(b);

//Задача 44
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), a0 = 1, a1 = 1;
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"{a0} ");
//     int x = a0 + a1;
//     a0 = a1;
//     a1 = x;
// }

//Задача 45
// int[] a = { 1, 2, 3, 4, 5 };
// int[] b = a;
// for (int i = 0; i < a.Length; i++)
//     b[i] = a[i];
// b[0] = -1;
// Console.WriteLine($"{string.Join(", ", a)}");
// Console.WriteLine($"{string.Join(", ", b)}");

// double n = new Random().NextDouble() * (end - begin) + begin
//Console.WriteLine(new Random().NextDouble() * (10 + 10) - 10); // ДРОБНЫЕ ОТРИЦАТЕЛЬНЫЕ!!! [-10, 10] 


// //Задача 46. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);


// //Задача 48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             //matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//             matrix[i, j] = i + j;
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);


// //Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса нечетные, и замените эти элементы на их квадраты.
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// void ReleaseMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i % 2 == 1)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (j % 2 == 1)
//                     matrix[i, j] *= matrix[i, j];
//             }
//         }
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }       
// }
// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine();
// ReleaseMatrix(matrix);


//Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// int ReleaseMatrix(int[,] matrix)
// {
//     int result = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == i)
//                 result += matrix[i, j];
//         }
//     }
//     return result;
// }
// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine();
// Console.WriteLine(ReleaseMatrix(matrix));

// //Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//     }
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }
// int[,] ReplaceString(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;
//     }
//     return matrix;
// }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // size[0] - row
// // size[1] - column
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Конечный массив:");
// PrintMatrix(ReplaceString(matrix));

// // Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//     }
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }
// int[,] ReplaceElement(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
//     return matrix;
// }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // size[0] - row
// // size[1] - column
// while (size[0] != size[1])
// {
//     Console.Write("Вы ошиблись!\nВведите размер матрицы: ");
//     size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Конечный массив:");
// PrintMatrix(ReplaceElement(matrix));

//// Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//     }
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }
// void DictionaryMatrix(int[,] matrix)
// {
//     int count = 1;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             count = 1;
//             if (matrix[i, j] != -100)
//             {
//                 for (int k = 0; k < matrix.GetLength(0); k++)
//                 {
//                     for (int m = 0; m < matrix.GetLength(1); m++)
//                     {  
//                         if (matrix[i, j] == matrix[k, m] && (i != k || j != m))
//                         {
//                             matrix[k, m] = -100;
//                             count++;
//                         }
//                         // PrintMatrix(matrix);
//                         // Console.WriteLine();
//                     }
//                 }
//                 Console.WriteLine($"{matrix[i, j]} встречается {count} раз");
//             }
//         }
//     }
// }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // size[0] - row
// // size[1] - column
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Конечный массив:");
// DictionaryMatrix(matrix);

//// Задача 57. Вариант решения 2.0
// bool checkValue(int[] array, int numbers)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == numbers)
//             return false;
//     }
//     return true;
// }
// int InputMatrix(int[,] matrix, int[] array)
// {
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} \t");
//             if (checkValue(array, matrix[i, j]))
//             {
//                 array[k] = matrix[i, j];
//                 k++;
//             }
//         }
//         Console.WriteLine();
//     }
//     return k;
// }
// void SwapFirstLastString(int[,] matrix, int[] array, int countNumbers)
// {
//     for (int k = 0; k < countNumbers; k++)
//     {
//         int count = 1;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (array[k] == matrix[i, j])
//                     count++;
//             }
//         }
//         Console.WriteLine($"Элемент {array[k]} встречается {count}  раз");   
//     }
// }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// int[] array = new int[coord[0] * coord[1]];
// Console.WriteLine("Начальный массив");
// int count = InputMatrix(matrix, array);
// Console.WriteLine("Конечный массив");
// SwapFirstLastString(matrix, array, count);

//// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// void SwapFirstLastString(int[,] matrix)
// {
//     int minValue = matrix[0, 0], minRow = 0, minColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (minValue > matrix[i, j])
//             {
//                 minValue = matrix[i, j];
//                 minRow = i;
//                 minColumn = j;
//             }
//         }
//     }
//     Console.WriteLine($"{minValue}({minRow}, {minColumn}) - минимум");   
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i != minRow)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (j != minColumn)
//                     Console.Write($"{matrix[i, j]} \t");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// Console.WriteLine("Начальный массив");
// InputMatrix(matrix);
// Console.WriteLine("Конечный массив");
// SwapFirstLastString(matrix);



//                                                      РЕКУРСИЯ!!!!!!!!!!!!!!!!

//// Простая задача на рекурсию. Произвести сложение без сложения используя только +1 и -1.
// int sum(int a, int b)
// {
// if (b == 0)
// return a;
// return sum(a + 1, b - 1);
// }
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sum(n, m));

//// Задача. Дана последовательность чисел завершаюшаяся числом 0. Найдите сумму всех этих чисел не используя цикл.
// int sum()
// {
// int x = Convert.ToInt32(Console.ReadLine());
// if (x == 0)
// return 0;
// return sum() + x;
// }
// Console.Clear();
// Console.WriteLine(sum());

// // Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// string rec(int n)
// {
//     if (n == 1)
//         return "1 ";
//     return $"{n} " + rec(n - 1);
// }
// Console.Clear();
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));

// // Задача 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// string rec(int m, int n)
// {
//     if (m == n)
//         return $"{n}";
//     return $"{m} " + rec(m + 1, n);
// }
// Console.Clear();
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(m, n));

// // Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// int rec(int n)
// {
//     if (n / 10 == 0 || n < 10 || n % 10 == n)
//         return n;
//     return rec(n / 10) + n % 10;
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));

// Задача 69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
int rec(int m, int n)
{
    if (n == 0)
        return 1;
    return m * rec(m, n-1);
}
Console.Clear();
Console.Write("Введите число А: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число А в степени Б равное: {rec(m, n)}");