// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1) Console.WriteLine($"первые {number} чисел Фибоначчи {NumberFebinachi(number)}");


string NumberFebinachi(int num)
{
    string result = "0 1 ";
    int num1 = 0;
    int num2 = 1;
    int num3 = default;
    for (int i = 1; i <= num - 2; i++)
    {

        string tmp = Convert.ToString(num2 + num1);
        result += tmp + " ";
        num3 = num1;
        num1 = num2;
        num2 += num3;
    }
    return result;
}