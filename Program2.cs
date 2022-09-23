Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1 - b2)/(k2 - k1);
double x1 = Math.Round (x, 2 );
double y = k1 * x + b1;
double y2 = Math.Round (y, 2 );

Console.WriteLine($"Точки пересечения двух прямых: ({x1}, {y2})");