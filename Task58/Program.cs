// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i,j]=sum;
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" |");
        }
        Console.WriteLine(" ]");
    }
}

Console.Write("Введите Размеры первой матрицы : ");
Console.Write("Введите количество строк двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] MatrixRndInt1 = CreateMatrixRndInt(m, n, 1, 5);


Console.Write("Введите Размеры второй матрицы : ");
Console.Write("Введите количество строк двумерного массива : ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива : ");
n = Convert.ToInt32(Console.ReadLine());
int[,] MatrixRndInt2 = CreateMatrixRndInt(m, n, 1, 20);
if (MatrixRndInt1.GetLength(1) != MatrixRndInt2.GetLength(0))
{
    Console.WriteLine("***********************************");
    Console.WriteLine(" Такие матрицы перемножить нельзя!");
    Console.WriteLine("***********************************");
    return;
}

Console.WriteLine("\n\nВаши матрицы");
PrintMatrix(MatrixRndInt1);
Console.WriteLine("====================");
PrintMatrix(MatrixRndInt2);
Console.WriteLine("====================");

Console.WriteLine("\n\nПроизведение матриц");
int[,] result = CompositionMatrix(MatrixRndInt1, MatrixRndInt2);
PrintMatrix(result);
