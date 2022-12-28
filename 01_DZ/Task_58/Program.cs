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

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[2, 2];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)      //по правилам математики for (int j = 0; j < matrix2.GetLength(1); j++)  
        {
            resultMatrix[i, j] = 0;                                 //как просили на семинаре
            resultMatrix[i, j] += matrix1[i, j] * matrix2[i,j];
        //     for (int k = 0; k < matrix1.GetLength(1); k++)             //по правилам математики
        // {
        //     resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        // }
        }
    }
    return resultMatrix;
}

Console.Clear();
int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] resultMatrix = new int[2, 2];
Console.WriteLine("Матрица 1:");
InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
resultMatrix = MultiplicationMatrix(matrix1, matrix2);
Console.WriteLine("Конечная матрица:");
PrintMatrix(resultMatrix);
