try
{
    double a, b, c, d;
    Console.WriteLine("Введіть значення a:");
    a = double.Parse(Console.ReadLine());

    Console.WriteLine("Введіть значення b:");
    b = double.Parse(Console.ReadLine());

    Console.WriteLine("Введіть значення c:");
    c = double.Parse(Console.ReadLine());

    Console.WriteLine("Введіть значення d:");
    d = double.Parse(Console.ReadLine());

    // Перевірка на ділення на нуль
    if (c != 0 && d != 0 && c != d && b != a && a != c)
    {
        double x = (a + 2.0 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2) ;
        Console.WriteLine("x = " + x);

        double y = (5.0 * (a + b) * (c - d)) / ((1 / 2.0) * c) + ((Math.Pow(d, 2)) * (Math.Pow(a, 2) - Math.Pow(b, 2))) / (b - a);
        Console.WriteLine("y = " + y);

        double z = ((Math.Pow((x * x - 2 * x), 3) - 4.0 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5.0 * a + 3.0 * b);
        Console.WriteLine("z = " + z);

        double r = ((((1 / 2.0) * a + (3 / 4.0) * b) - (7 / 5.0)) / (3.0 * c + 1)) + 1 / (a - c);
        Console.WriteLine("r = " + r);
    }
    else
    {
        Console.WriteLine("Помилка: некоректні вхідні дані (можливе ділення на нуль).");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Помилка введення: " + ex.Message);
}
