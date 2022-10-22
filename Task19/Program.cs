// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = 0;
while (number < 10000 || number > 99999)
{
    Console.Write("ВВедите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());

}
if (Palindrom(number)) Console.WriteLine($"{number} Палиндром");
else Console.WriteLine($"{number} совсем НЕ палиндром");

bool Palindrom(int num)
{
    int n1 = num / 10000;
    int n2 = num / 1000 % 10;
    int n4 = num / 10 % 10;
    int n5 = num % 10;
    // Console.WriteLine($"{n1} {n2} {n4} {n5} ");
    if (n1 == n5 && n2 == n4) return true;
    return false;
}