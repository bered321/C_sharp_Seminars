Console.Clear();
Console.Write("Введите пятизначное число: ");
int forward = Convert.ToInt32(Console.ReadLine());
int palindrom = -1;
while (forward < 10000 || forward >= 100000)
{
    Console.WriteLine("Вы ошиблись! \nВведите пятизначное число: ");
    forward = Convert.ToInt32(Console.ReadLine());
}
string b = forward.ToString();
for (int i = 0; i < (forward.ToString().Length - 1) / 2; i++)
{
    if (b[i] == b[forward.ToString().Length - 1 - i])
        palindrom = 1;
    else
        palindrom = 0;
}
if (palindrom == 1)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число является не палиндромом");
