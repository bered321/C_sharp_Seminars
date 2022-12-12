bool Prostoe(int number)
{
    if (number < 2) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;
    for (int i = 3; (i * i) <= number; i += 2)
    {
        if (number % i == 0) return false;
    }
    return true;
}


Console.Clear();
Console.Write("Введите четное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n <= 3 || n >= 999 || n % 2 != 0)
{
    Console.WriteLine("Вы ошиблись!\nВведите правильное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

for (int i = 2; i < n; i++)
{
    Prostoe(i);
    Prostoe(n - i);
    if (Prostoe(i) == true && Prostoe(n - i) == true)
    {
        Console.WriteLine($"Первое простое слогаемое: {i} \nВторое простое слогаемое: {n - i}");
        break;
    }
}



