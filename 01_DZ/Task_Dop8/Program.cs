﻿//Задача Доп 8. Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали. 

void Matrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 51); 
    }
}

void Result(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[matrix.GetLength(0) - 1 - i, j];
            matrix[matrix.GetLength(0) - 1 - i, j] = temp;
        }
    }
}

void Print(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Matrix(matrix);
Console.WriteLine("Начальный массив:");
Print(matrix);
Result(matrix);
Console.WriteLine("Конечный массив:");
Print(matrix);