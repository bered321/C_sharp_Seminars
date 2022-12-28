int rec(int m, int n)
{
    if (m == n)
        return n;
    return m + rec(m + 1, n);
}
Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {rec(m, n)}");