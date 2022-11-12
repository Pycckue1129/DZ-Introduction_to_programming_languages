Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int chet = 2;

while (chet <= a) 
{
    Console.Write(chet + " ");
    chet = chet + 2;
}