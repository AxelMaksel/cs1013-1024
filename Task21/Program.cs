// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] x = { 0, 0 };
int[] y = { 0, 0 };
int[] z = { 0, 0 };

for (int i = 0; i < 2; i++)
{
    Console.Write($"ВВЕдите x{i + 1} ");
    x[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"ВВЕдите y{i + 1} ");
    y[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"ВВЕдите z{i + 1} ");
    z[i] = Convert.ToInt32(Console.ReadLine());
}


int xPoint = x[1] - x[0];
int yPoint = y[1] - y[0];
int zPoint = z[1] - z[0];

Console.WriteLine($"длинна {Res(xPoint, yPoint, zPoint)}");

double Res(int xx, int yy, int zz)
{
    double r = Math.Sqrt(xx * xx + yy * yy+ zz * zz);
    r = Math.Round(r, 2, MidpointRounding.ToZero);

    return r;
}
