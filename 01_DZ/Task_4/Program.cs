Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
    Console.WriteLine($"max = {a}");
else if (b > a && b > c)
    Console.WriteLine($"max = {b}");
else if (a == b && b == c)
    Console.WriteLine("Числа равны");
else
    Console.WriteLine($"max = {c}");
