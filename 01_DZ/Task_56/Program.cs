void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void NumberMinSumRow(int[,] matrix)
{
    int number = 0;
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int SumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow = SumRow + matrix[i, j];
        }
        array[i] = SumRow;
    }
    int MinSumRow = 0;
    for (int k = 1; k < matrix.GetLength(0); k++)
    {
        if (array[MinSumRow] > array[k])
        {
            number = k;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {number + 1}");
}

Console.Clear();
int[,] matrix = new int[5, 3];
Console.WriteLine("Матрица:");
InputMatrix(matrix);
PrintMatrix(matrix);
NumberMinSumRow(matrix);
