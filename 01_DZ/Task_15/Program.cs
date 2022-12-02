Console.Clear();
Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 7 || a < 1)
    Console.WriteLine("Введен не верный номер дня недели");
else if (a == 6 || a == 7)
    Console.WriteLine("Выходной");
else if (a > 0 || a < 7)
    Console.WriteLine("Будний");
