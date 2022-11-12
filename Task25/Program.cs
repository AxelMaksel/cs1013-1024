// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("ВВедите основание степени больше нуля: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите показатель степени больше нуля: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (num > 0 && degree > 0)
{
    int numDegree = Exponentiation(num, degree);
    Console.WriteLine($"Ответ: {num} в степени {degree} = {numDegree}");
}
else
{
    Console.WriteLine("Ошибка ввода данных");
}


int Exponentiation(int number, int degree_)
{
    int result = number;
    for (int i = 1; i < degree_; i++)
    {
        result *= number;
    }
    return result;
}