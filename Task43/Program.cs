// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите значение B1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение K1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение B2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение K2 ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] result = Finddoubleersection(k1, b1, k2, b2);
Console.WriteLine($"Точка пересечения имеет координаты {result[0]} {result[1]}");

double[] Finddoubleersection(double n1, double m1, double n2, double m2)
{
    double x = (m2 - m1) / (n1 - n2);
    double y = n2 * x + m2;
    double[] res = new double[2];
    res[0] = x;
    res[1] = y;
    return res;
}