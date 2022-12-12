Console.Clear();
Console.Write("Введите количество элементов последовательности : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(1, 11);
int temp = 0;
Console.WriteLine();
Console.WriteLine($"Изначальный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Console.Write("Введите количество элементов на которое необходимо сдвинуть последовательность : ");
int k = Convert.ToInt32(Console.ReadLine());
if (k > 0)
{
    k %= n;
    for (int i = 0; i < k; i++)
    {
        temp = array[array.Length - 1];
        for (int j = array.Length - 2; j >= 0; j--)
        {
            array[j + 1] = array[j];
        }
        array[0] = temp;
    }
}
else if (k < 0)
{
    k = k * (-1);
    k %= n;
    for (int i = 0; i < k; i++)
    {
        temp = array[0];
        for (int j = 0; j < array.Length - 1; j++)
        {
            array[j] = array[j + 1];
        }
        array[array.Length - 1] = temp;
    }
}
Console.WriteLine($"Массив после сдвига: [{string.Join(", ", array)}]");


