// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int j = 0; j < matrix.GetLength(1); j++) // 2
    {
        for (int i = 0; i < matrix.GetLength(0); i++) matrix[i, j] = rnd.Next(min, max + 1);

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}
int SumElementMatrix(int[,] matrix)
{
    int min = matrix.GetLength(0);
    int sum = 0;
    if (matrix.GetLength(1) < min) min = matrix.GetLength(1);
    for (int i = 0; i < min; i++) sum += matrix[i, i];
    return sum;
}

int[,] array2D = CreateMatrixRndInt(5, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine("=========================");
Console.WriteLine(SumElementMatrix(array2D));
