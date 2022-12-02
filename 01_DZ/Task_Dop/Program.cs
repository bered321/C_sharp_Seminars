Console.Clear();
Console.WriteLine("Введи последовательность чисел: ");
int a = Convert.ToInt32(Console.ReadLine());
int max1 = a;
int max2 = a;
while (a != 0)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a > max1)
    {
        max2 = max1;
        max1 = a;
    }
    else if (a > max2 && a < max1)
        {
            max2 = a;
        }
    
}
Console.WriteLine();
Console.WriteLine($"Второй максимум {max2}");
