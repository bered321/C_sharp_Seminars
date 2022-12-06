using System;
Console.Clear();
Console.Write("Введите пятизначное число: ");
int forward = Convert.ToInt32(Console.ReadLine());
int palindrom = 0;
while (forward < 10000 || forward >= 100000)
{
    Console.WriteLine("Вы ошиблись! \nВведите пятизначное число: ");
    forward = Convert.ToInt32(Console.ReadLine());
}
int N = forward.ToString().Length - 1;
string b = forward.ToString();
for (int i = 0; i < N / 2; i++)
{
    if (b[i] != b[N - i])
        palindrom = 0;
    else
        palindrom = 1;
}
if (palindrom == 1)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число является не палиндромом");
