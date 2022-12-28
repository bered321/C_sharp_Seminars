


Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
int[,,] a = new int[size[0], size[1], size[2]];
while (size[0] * size[1] * size[2] > 99)
{
    Console.Write("Вы ввели превышающие размеры! \nВведите их зановго: ");
    size = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
}

for (int i = 0; i < a.GetLength(0); i++)
{

    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int k = 0; k < a.GetLength(2); k++)
        {
            for (int c = 0; c < a.GetLength(0) * a.GetLength(1) * a.GetLength(2); c++)

            { a[i, j, k] = c; }
        }
    }
}
for (int i = 0; i < a.GetLength(0); i++)
{
    Console.WriteLine("Страница №: " + (i + 1));

    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int k = 0; k < a.GetLength(2); k++)
        {
            Console.Write(a[i, j, k] + "(" + i + j + k + "); ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}