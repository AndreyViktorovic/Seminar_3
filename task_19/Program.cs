// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число");
int x1 = Convert.ToInt32(Console.ReadLine());

if (x1 > 4 && x1 < 6)
{
    Console.WriteLine("Ну я же просил ПЯТИЗНАЧНОЕ число");
}
else
{
    int i1 = (x1 / 10000) % 10;
    int y1 = x1 % 10;
    if (i1 == y1)
    {
        int i2 = (x1 / 1000) % 10;
        int y2 = (x1 /10)% 10;
        if (i2 == y2)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
