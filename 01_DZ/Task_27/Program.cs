Console.Clear();
Console.Write("Введите число : ");
string? a = Console.ReadLine();
int[] b = new int[a.Length];
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    b[i]=Convert.ToInt32(a[i].ToString());
    sum = sum + b[i];
}
Console.WriteLine($"Сумма цифр в числе равна: {sum}");