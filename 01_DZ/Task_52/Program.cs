//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

double[] Avarage(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double avg = 0;
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        avg = Math.Round(sum / matrix.GetLength(0), 2);
        result[j] = avg;
    }
    return result;
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", Avarage(matrix))}");
