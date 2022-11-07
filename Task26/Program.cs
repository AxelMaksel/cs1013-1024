// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Write("ВВедите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int lenNumbers = LenNumbers(num);
Console.WriteLine($"Колличество цифр в числе {num} = {lenNumbers}");

int LenNumbers(int number)
{
    int len = default;
    while (number >= 1)
    {
        number /= 10;
        len ++;    
    }
        
    return len;
}