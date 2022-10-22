// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.Write("ВВедите Четверть:");
int quar = Convert.ToInt32(Console.ReadLine());


string result = Quarter(quar);
Console.WriteLine(result);

string Quarter(int q)
{
    if (q == 1) return "x > 0 , y > 0";
    if (q == 2) return "x > 0 , y < 0";
    if (q == 3) return "x < 0 , y < 0";
    if (q == 4) return "x > 0 , y > 0";
    
    return "ОШИБКА!!";
}



