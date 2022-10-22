// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int num = 0;
while (num < 1)
{
    Console.WriteLine("ВВедите число");
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        KvadratNum(num);
        break;
    }
}

void KvadratNum(int num1)
{
    for (int i = 1; i <= num1; i++) Console.WriteLine($"{i,5}\t|{Math.Pow(i,3),5}");
}
