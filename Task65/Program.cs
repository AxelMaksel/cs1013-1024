// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите 2 числа");
Console.Write("Введите первое ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе ");
int number2 = Convert.ToInt32(Console.ReadLine());

void NaturNum(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturNum(num1 + 1, num2);
    }

    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturNum(num1 - 1, num2);
    }
    if (num1 == num2) Console.Write($"{num1} ");

}

NaturNum(number1, number2);