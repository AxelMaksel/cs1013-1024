// void Metod()
// {
//     int[] r2 = { 1, 3, 5, 7, 9 };
//     foreach (int r in r2)
//     {
//         Console.WriteLine(r);
//     }
//     for (int i = 0; i < r2.Length; i++)
//     {
//         Console.WriteLine(r2[i]);
//     }

// }

// void Metod2(string inet, int count)
// {
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine($"{inet} {i} {Metod3()}");
//     }

// }
// int Metod3()
// {
//     return DateTime.Now.Year;
// }

// int Metod4(int num)
// {
//     return num * num;
// }

// Metod();
// Metod2(count: 5, inet: "PRIVET");
// int year = Metod3();
// Console.WriteLine($"{year}) {Metod4(3)}");

// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         Console.WriteLine($"{i}*{j}={i * j}");
//     }
//     Console.WriteLine();
// }


int[] arr = { 1, 3, 5, 2, 4, 6, 8, 2, 8, 3, 6 };
PrintArr(arr);
SelectionSort(arr);
PrintArr(arr);

void PrintArr(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

