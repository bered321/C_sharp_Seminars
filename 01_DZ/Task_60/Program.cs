void InputCube(int[,,] Cube)
{
    int count = 10;
    for (int i = 0; i < Cube.GetLength(0); i++)
    {
        for (int j = 0; j < Cube.GetLength(1); j++)
        {
            for (int k = 0; k < Cube.GetLength(2); k++)
            {
                Cube[i, j, k] += count;
                count++;
            }    
        }   
    }
}

void PrintCube(int[,,] Cube)
{
    for (int i = 0; i < Cube.GetLength(0); i++)
    {
        for (int j = 0; j < Cube.GetLength(1); j++)
        {
            for (int k = 0; k < Cube.GetLength(2); k++)
                Console.Write($"{Cube[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}



Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
int[,,] Cube = new int[size[0], size[1], size[2]];
while (size[0] * size[1] * size[2] > 99)
{
    Console.Write("Вы ввели превышающие размеры! \nВведите их зановго: ");
    size = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
}
InputCube(Cube);
PrintCube(Cube);