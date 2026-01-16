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
}

class Cylinder : Figure
{
    public Circle? Circle { get; set; }
    private double height;
    public double Height
    {
        get => height;
        set { if(value > 0) height = value; }
    }
    public override double getArea()=>2*Math.PI* (height+Circle!.Radius);
    public override double getPerimetr() => 2 * (2 * Circle!.Radius + height);
}