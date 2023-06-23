// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер чeтверти");
int i = Convert.ToInt32(Console.ReadLine());

if(i == 1)
{
    Console.WriteLine("x>0 , y>0");
}
else if(i == 2)
{
    Console.WriteLine("x>0 , y>0");
}
else if(i == 3)
{
    Console.WriteLine("x<0 , y<0");
}
else if(i == 4)
{
    Console.WriteLine("x>0 , y<0");
}
else 
{
    Console.WriteLine("не понятно");
}