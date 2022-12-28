int rec(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return rec(m - 1, 1);
    else 
        return rec(m - 1, rec(m, n - 1));
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат вычисления функции Аккермана: {rec(m, n)}");