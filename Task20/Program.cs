// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.Write("ВВЕдите x1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("ВВЕдите y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("ВВЕдите x2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("ВВЕдите y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());

double x = x2 - x1;
double y = y2 - y1;

Console.WriteLine($"длинна {Res(x, y)}");

double Res(double xx, double yy)
{
    double r = Math.Sqrt(x * x + y * y);
    r = Math.Round(r, 2, MidpointRounding.ToZero);

    return r;
}
