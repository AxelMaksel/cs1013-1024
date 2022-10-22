// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThreeDigit(int num)
{
    while (num > 999) num =num /10;
    return (num % 10);
}

Console.Write("ВВедите число больше 99: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99) Console.WriteLine(ThreeDigit(number));
else Console.Write("Не верный ввод!");

