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
