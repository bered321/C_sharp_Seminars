void Yagodi(int[] KolYagod)
{
    int length = KolYagod.Length;
    int maxsum = 0;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите количество ягод на {i + 1}-м кусте");
        KolYagod[i] = Convert.ToInt32(Console.ReadLine());
        maxsum = maxsum + KolYagod[i];
        if (maxsum > 1000)
        {
            Console.WriteLine("Общее кол-во ягод на кустах превышает допустимое значение");
            break;
        }
    }
}

Console.Clear();
Console.Write("Введите количество кустов: ");
int KolKustov = Convert.ToInt32(Console.ReadLine());
int max = 0;
int CurrentMax = 0;

while (KolKustov < 3 || KolKustov > 1000)
{
    Console.WriteLine("Вы ошиблись! \nВведите правильное кол-во кустов: ");
    KolKustov = Convert.ToInt32(Console.ReadLine());
}
int[] KolYagod = new int[KolKustov];
Yagodi(KolYagod);
for (int i = 0; i < KolKustov; i++)
{
    if (i == 0)
    {
        CurrentMax = KolYagod[KolKustov - 1] + KolYagod[0] + KolYagod[1];
        max = CurrentMax;
    }
    else if (i > 0 && i < KolKustov - 1)
    {
        CurrentMax = KolYagod[i - 1] + KolYagod[i] + KolYagod[i + 1];
        if (CurrentMax > max)
            max = CurrentMax;
    }
    else
    {
        CurrentMax = KolYagod[KolKustov - 1] + KolYagod[KolKustov - 2] + KolYagod[0];
        if (CurrentMax > max)
            max = CurrentMax;
    }
}
Console.WriteLine($"Максимальное число ягод, которое может собрать за один заход собирающий модуль: {max}");



