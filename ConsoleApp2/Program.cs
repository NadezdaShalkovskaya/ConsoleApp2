try
{
    double b = 2.19;
    double k = 1.7;
    double t = Math.Pow(k, 2) * Math.Sqrt(b);
    Console.WriteLine($" число t = {t:F2}");
    double a = b + Math.Pow(t, 2) * Math.Pow(Math.E, t);
    Console.WriteLine($"число a = {a:F2}");
    double y = Math.Pow(Math.Cos(Math.Pow(a, 3) + b), 4);
    Console.WriteLine($"число y = {y}");
}
catch {
    Console.WriteLine("Введите корректные данные");
}