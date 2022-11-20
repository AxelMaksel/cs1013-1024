// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Double[,] CreateMatrixRndDouble(int rows, int columns, Double min, Double max)
{
    Double[,] matrix = new Double[rows, columns];
    Random rnd = new Random();
    for (int j = 0; j < matrix.GetLength(1); j++) // 2
    {
        for (int i = 0; i < matrix.GetLength(0); i++) matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return matrix;
}
void PrintMatrix(Double[,] matrix)
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

Double[,] array2D = CreateMatrixRndDouble(3, 4, 0, 9);
PrintMatrix(array2D);