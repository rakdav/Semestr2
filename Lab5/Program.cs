//1
//try
//{
//    Console.Write("Введите x1:");
//    double x1 = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите y1:");
//    double y1 = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите x2:");
//    double x2 = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите y2:");
//    double y2 = double.Parse(Console.ReadLine()!);
//    double D = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1-y2) * (y1-y2));
//    Console.WriteLine($"D={D:F2}");
//}
//catch { }
//2
//try
//{
//    Console.Write("Введите x1:");
//    double x1 = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите y1:");
//    double y1 = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите x2:");
//    double x2 = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите y2:");
//    double y2 = double.Parse(Console.ReadLine()!);
//    if (x1 == x2 && y1 == y2) throw new Exception("Координаты в одной точке");
//    double D = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
//    Console.WriteLine($"D={D:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//3

//try
//{
//    Console.Write("Введите x1:");
//    double x1 = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите y1:");
//    double y1 = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите x2:");
//    double x2 = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите y2:");
//    double y2 = double.Parse(Console.ReadLine()!);
//    if (x1 == x2 && y1 == y2) throw new Exception("Координаты в одной точке");
//    double D = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
//    Console.WriteLine($"D={D:F2}");
//}
//catch(FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//4
try
{
    Console.Write("Введите x1:");
    double x1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите y1:");
    double y1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите x2:");
    double x2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите y2:");
    double y2 = double.Parse(Console.ReadLine()!);
    if (x1 == x2 && y1 == y2) throw new PointException("Координаты в одной точке", new MyPoint(x1, y1));
    double D = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    Console.WriteLine($"D={D:F2}");
}
catch (PointException ex)
{
    Console.WriteLine(ex.Message + " " + ex.Value);
}
class MyPoint
{
    public double X { get; set; }
    public double Y { get; set; }
    public MyPoint(double x, double y)
    {
        X = x;
        Y = y;
    }
    public override string? ToString()
    {
        return $"({X};{Y})";
    }
}
class PointException : Exception
{
    public MyPoint Value { get; }
    public PointException(string? message, MyPoint val) : base(message)
    {
        Value = val;
    }
}