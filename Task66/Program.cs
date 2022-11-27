// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите 2 числа");
Console.Write("Введите первое ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 < number1)
{
    int tmp = number1;
    number1 = number2;
    number2 = tmp;
}
Console.WriteLine($"Числа {number1} {number2}");

int sum = NaturNum(number1, number2);
Console.WriteLine($"Summa {sum}");

int NaturNum(int num1, int num2)
{
    if (num1 < num2) return num1 + NaturNum(num1 + 1, num2);
    return num1;
}

