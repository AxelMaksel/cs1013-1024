// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ConvertToBin(number));


string ConvertToBin(int num)
{
    string result = "";
    int dig1 = default;
    while (num > 0)
    {
        dig1 = num % 2;
        result = Convert.ToString(dig1) + result;
        num /= 2;
    }
    return result;
}


