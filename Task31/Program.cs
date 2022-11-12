// Создать массив случайных чисел от -9 до 9
// найти сумму отрицательных и положительных значений

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] GetSumPositiveNegativeElem(int[] array)
{
    int SumPositive = 0;
    int SumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) SumPositive += array[i];
        else SumNegative += array[i];
    }
    return new int[] { SumPositive, SumNegative };
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов {getSumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов {getSumPositiveNegativeElem[1]}");
