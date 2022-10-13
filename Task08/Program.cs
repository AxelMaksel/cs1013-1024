// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.Write("Введи число ");
int num = Convert.ToInt32(Console.ReadLine());

int cnt = 1;
if (num > 1)
{
   while (cnt <= num)
{
    if (cnt % 2 == 0) Console.Write($"{cnt} ");
    cnt ++;
} 
}
else Console.WriteLine("Тут нечего выводить ваше число меньше 2");


