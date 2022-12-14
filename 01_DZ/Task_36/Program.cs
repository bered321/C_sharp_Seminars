﻿void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21); 
}

int sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum=sum+array[i];
    return sum;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов с нечетными индексами в массиве равна: {sum(array)}");
