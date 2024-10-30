using static System.Math;
double m, n, a, b, x;
Console.Write("Введiть число m: ");
m = double.Parse(Console.ReadLine());
Console.Write("Введiть число n: ");
n = double.Parse(Console.ReadLine());
Console.Write("Введiть число a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Введiть число b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Введiть число x: ");
x = double.Parse(Console.ReadLine());

double z1, z2, y;
z1 = ((m - 1) * Sqrt(m) - (n - 1) * Sqrt(n)) / (Sqrt(Pow(m,3) * n) + n * m + Pow(m,2) - m);
z2 = (Sqrt(m) - Sqrt(n)) / m;
y = 2.4 * Abs((Pow(x,2) + b) / a) + (a-b) * Pow(Sin(a - b),2) + Pow(10.0,-2) * (x - b);

Console.WriteLine("Вихiднi данi:");
Console.WriteLine("\tz1 = "+ z1);
Console.WriteLine("\tz2 = "+ z2);
Console.WriteLine("\ty  = "+ y);
