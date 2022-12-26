void FirstMatrix(int[,] MatrixOne)
{
    Console.WriteLine();
    Console.WriteLine("Введите исходное бинарное черно-белое изображение:");
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
    {
        string? input = Console.ReadLine();
        for (int j = 0; j < input.Length; j++)
        {
            MatrixOne[i, j] = input[j];
        }
    }
}
 
void SecondMatrix(int[,] MatrixTwo)
{
    Console.WriteLine("Введите полученный Мишиной программой негатив:");
    for (int i = 0; i < MatrixTwo.GetLength(0); i++)
    {
        string? input = Console.ReadLine();
        for (int j = 0; j < input.Length; j++)
        {
            MatrixTwo[i, j] = input[j];
        }
    }
}
 
void Result(int[,] MatrixOne, int[,] MatrixTwo)
{
    int count = 0;
    for (int i = 0; i < MatrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixTwo.GetLength(1); j++)
        {
            if (MatrixOne[i, j] == MatrixTwo[i, j])
                count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Число неправильно сформированых пикселей негатива равно: {count}");
}
 
Console.Clear();
Console.Write("Введите через пробел кол-во строк и столбцов: ");
string? numbers = Console.ReadLine(); 
int n = Convert.ToInt32(numbers[0].ToString());
int m = Convert.ToInt32(numbers[2].ToString());
int[,] MatrixOne = new int[n, m];
int[,] MatrixTwo = new int[n, m];
FirstMatrix(MatrixOne);
Console.WriteLine();
SecondMatrix(MatrixTwo);
Result(MatrixOne, MatrixTwo);