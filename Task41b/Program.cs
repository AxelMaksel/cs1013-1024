// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("ВВедите колличество чисел для ввода ");
int numM = Convert.ToInt32(Console.ReadLine());// Positive колличество чисел
int[] arrayForTest = new int[numM];// Positive массив для чисел
arrayForTest = NumberPositive(numM);

int numberP = CountPosinive(arrayForTest);
Console.WriteLine($"Вы ввели {numberP} положительных чисел");


int[] NumberPositive(int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($"ВВедите {i}-е число для проверки ");
        arrayForTest[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrayForTest;
}

int CountPosinive(int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positive++; ;
    }
    return positive;
}

