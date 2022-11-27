// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 99;
int n = 99;
Console.WriteLine("Для выхода из программы наберайте число 33");
while (0 < m && m > 3)
{
    Console.Write("Введите число M < 4: ");
    m = Convert.ToInt32(Console.ReadLine());
    if (m == 33) return;
}

while (0 < n && n > 11)
{
    Console.Write("Введите число N < 12: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n == 33) return;
}
Console.Write(Akkerman(m, n));


// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    else return (Akkerman(m - 1, Akkerman(m, n - 1)));
}