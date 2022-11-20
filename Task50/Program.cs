// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int j = 0; j < matrix.GetLength(1); j++)
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
void InsertElementMatrix(int[,] matrix, int rows, int columns)
{
    if (rows <= matrix.GetLength(0) && columns <= matrix.GetLength(1)) Console.WriteLine($"В ячейке {rows},{columns} лежит значение {matrix[rows, columns]}");
    else Console.WriteLine($"Нет элемента [{rows},{columns}]");
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);

Console.WriteLine("===========================");
Console.Write("Ввелите номер строки с ноля ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Ввелите номер столбца с ноля ");
int column = Convert.ToInt16(Console.ReadLine());
InsertElementMatrix(array2D, row, column);
