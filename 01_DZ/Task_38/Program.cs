﻿void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (20 - 10) + 10, 2);
}

double minmax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (min > array[i])
            min = array[i];
    }
    return (Math.Round(max - min, 2));
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
Console.WriteLine($"Разница между max и min элементами массива: {minmax(array)}");


