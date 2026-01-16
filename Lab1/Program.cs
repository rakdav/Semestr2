Console.Write("Введите ширину прямоугольника:");
double height=double.Parse(Console.ReadLine()!);
Console.Write("Введите длину прямоугольника:");
double  width= double.Parse(Console.ReadLine()!);
Rectangle rectangle = new Rectangle(width,height);
Console.WriteLine(rectangle);

Console.Write("Введите радиус окружности:");
double radius= double.Parse(Console.ReadLine()!);
Circle circle=new Circle(radius);
Console.WriteLine(circle);

Console.Write("Введите высоту цилиндра:");
double h=double.Parse(Console.ReadLine()!);
Cylinder cylinder=new Cylinder(circle,h);
Console.WriteLine(cylinder);
abstract class Figure
{
    public abstract double getArea();
    public abstract double getPerimetr();
}
class Rectangle : Figure
{
    private double width;
    private double height;
    public double Width
    {
        get { return width; }
        set { if(value>0) width = value; }
    }
    public double Height
    {
        get { return height; }
        set { if (value > 0) height = value; }
    }
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public override double getArea()=>width * height;
    public override double getPerimetr()=>2 * (height + width);

    public override string? ToString()
    {
        return $"Прямоугольник длиной {width} и шириной {width} имеет площадь " +
            $"{getArea():F2} и периметр {getPerimetr():F2}";
    }
}
class Circle : Figure
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double Radius
    {
        get { return radius; }
        set { if (value > 0) radius = value; }
    }
    public override double getArea() => Math.PI * radius * radius;
    public override double getPerimetr()=>2*Math.PI * radius;
    public override string? ToString()
    {
        return $"Окружность радиусом {radius} имеет площадь " +
            $"{getArea():F2} и периметр {getPerimetr():F2}";
    }
}

class Cylinder : Figure
{
    public Circle? Circle { get; set; }
    private double height;

    public Cylinder(Circle? circle, double height)
    {
        Circle = circle;
        this.height = height;
    }

    public double Height
    {
        get => height;
        set { if(value > 0) height = value; }
    }
    public override double getArea()=>2*Math.PI* (height+Circle!.Radius);
    public override double getPerimetr() => 2 * (2 * Circle!.Radius + height);
    public override string? ToString()
    {
        return $"Цилиндр радиусом основания {Circle!.Radius} и высотой {height} имеет площадь {getArea():F2} и периметр сечения {getPerimetr():F2}";
    }
}