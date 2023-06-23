// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите точку А координату по оси Х");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку А координату по оси Y");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку В координату по оси Х");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку В координату по оси Y");
int y2 = Convert.ToInt32(Console.ReadLine());

double skobX = Math.Pow(x1 - x2, 2);
double skobY = Math.Pow(y1 - y2, 2);  // Math.Pow(x, 2)- квадрат ; Math.Sqrt(х) -корень
double result = Math.Sqrt(skobX + skobY);

Console.WriteLine($"{result:f2}");     // f2- это округление после запятой, 2- сколько знаков