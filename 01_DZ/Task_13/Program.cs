Console.Clear();
Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; a > 1000; i++)
{
    a = a / 10;       
}
if (a > 100 && a < 1000)
{
    int n1 = a % 10;
    Console.WriteLine($"Третья цифра этого числа: {n1}");
}
else if (a < 100)
    Console.WriteLine("Третьего числа нет");


