Console.WriteLine("Введите число 1 : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3 : ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
    max = b;
if (max < c)
    max = c;
Console.WriteLine("Max = " + max);