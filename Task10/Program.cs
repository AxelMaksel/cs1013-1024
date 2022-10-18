// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int TwoDigit(int num)
{
    return (num / 10 % 10);
}

Console.Write("ВВедите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000) Console.WriteLine(TwoDigit(number));
else Console.Write("Не верный ввод!");
