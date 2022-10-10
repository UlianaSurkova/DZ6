Console.WriteLine("введите значение u");
double u = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число s");
double s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение t");
double t = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число a");
double a = Convert.ToInt32(Console.ReadLine());

double x = (t + u)/(s + a);
double y = a * x + t;

Console.WriteLine($"прямые пересекутся в точке координат {x}, {y}");
