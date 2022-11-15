// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите размер первой стороны ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер второй стороны ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер третий стороны ");
int c = Convert.ToInt32(Console.ReadLine());

if (TrueTriangle(a, b, c)) Console.WriteLine("Может такой быть!");
else Console.WriteLine("Такой не может быть!");

bool TrueTriangle(int x, int y, int z)
{
    return (x + y > z && x + z > y && z + y > x)  ;
}