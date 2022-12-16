Console.Clear();
Console.Write("Введите числа через пробел: ");
int count = 0;
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); //в одну строчку через пробел
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count += 1;
}
Console.WriteLine($"Пользователь ввел {count} положительных чисел");