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
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a*a==b || b*b==a )
    Console.WriteLine("да");
else
    Console.WriteLine("нет");

