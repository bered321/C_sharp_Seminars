int[,] SpiralMatrix(int[,] matrix, int n)
{
    int i = 0;
    int j = 0;
    int k = 0;
    int[,] resultMatrix = new int[n, n];
    while (k <= n * n)
    {
        resultMatrix[i, j] = k;
        if (i <= j + 1 && i + j < n - 1)
            j++;
        else if (i < j && i + j >= n - 1)
            i++;
        else if (i >= j && i + j > n - 1)
            j--;
        else
            i--;
        k++;
    }
    return resultMatrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры квадратной матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
while (size[0] != size[1])
{
    Console.Write("Вы ошиблись! \nВведите их зановго: ");
    size = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
}
matrix = SpiralMatrix(matrix, size[0]);
PrintArray(matrix);
