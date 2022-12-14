void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}

void day(int[] array)
{
    int chet = 0;
    int nechet = 0;
    Console.Write("Дни когда Вася получил 4: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            chet += 1;
            Console.Write($"{array[i]} ");
        }
    }
    Console.WriteLine();
    Console.Write("Дни когда Вася получил 3: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            nechet += 1;
            Console.Write($"{array[i]} ");
        }
    }
    Console.WriteLine();
    if (chet >= nechet)
        Console.WriteLine("Вася может рассчитывать на оценку 4");
    else
        Console.WriteLine("Вася может рассчитывать на оценку 3");
}


Console.Clear();
int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Дни, когда были уроки английского: {string.Join(", ", array)}");
day(array);
