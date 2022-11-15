// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("ВВедите колличество чисел для ввода ");
int numM = Convert.ToInt32(Console.ReadLine());
int numberP = NumberPositive(numM);
Console.WriteLine($"Вы ввели {numberP} положительных чисел");

int NumberPositive(int number)
{
    int positive = default;
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"ВВедите {i}-е число для проверки ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) positive++;
    }
    return positive;
}