// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("ВВедите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(num);
Console.WriteLine($"Сумма цифр в числе {num} = {sumNumbers}");

int SumNumbers(int number)
{
    int sum = default;
    while (number >= 1)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}