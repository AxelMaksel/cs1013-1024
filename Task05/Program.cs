Console.Write("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    int ns = -n;
    while (ns <= n)
    {
        Console.Write($"{ns} ");
        ns++;
    }
}
else Console.WriteLine("Natural number");