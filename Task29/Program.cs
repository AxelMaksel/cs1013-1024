// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int lenArray = 8;
int minNumber = 0;
int maxNumber = 99;
int[] array = new int[lenArray];
ArrayGeniratoin();
ArrayPrint();

void ArrayGeniratoin()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber + 1);
    }
}

void ArrayPrint()
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}
