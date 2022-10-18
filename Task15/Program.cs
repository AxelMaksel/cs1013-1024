// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string Day (int day)
{
    string stingDay="Ошибка ввода";
    if (day ==6 || day ==7) stingDay="УРА Выходной!!!";
    else if (day > 0 && day <6) stingDay="НЕ Выходной день";
    
    return stingDay;
}

Console.Write("ВВедите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Day(number));
