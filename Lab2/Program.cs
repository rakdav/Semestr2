//Complex z1=new Complex(1, 2);
//Complex z2=new Complex(2, 8);
//Complex z3=z1+z2;
//Console.WriteLine(z3);
//Complex z4 = z1 - z2;
//Console.WriteLine(z4);
//Complex z5 = z1 * z2;
//Console.WriteLine(z5);
//Console.WriteLine(z4==z5);
//Person[] person = new Person[4];
//person[0] = new Person("One");
//person[1] = new Person("Two");
//person[2] = new Person("Three");
//person[3] = new Person("Four");
//Company company = new Company(person);
//Person p = company[2];
//Console.WriteLine(p.Name);
//class Complex
//{
//    public double Re {  get; set; }
//    public double Im { get; set; }
//    public Complex(double re, double im)
//    {
//        Re = re;
//        Im = im;
//    }
//    public override string? ToString()
//    {
//        return "Z="+Re+((Im>=0)?"+":"")+Im+"i";
//    }
//    public static Complex operator + (Complex x, Complex y)
//    {
//        return new Complex(x.Re+y.Re,x.Im+y.Im);
//    }
//    public static Complex operator - (Complex x, Complex y)
//    {
//        return new Complex(x.Re - y.Re, x.Im - y.Im);
//    }
//    public static Complex operator * (Complex x, Complex y)
//    {
//        return new Complex(x.Re*y.Re - x.Im*y.Im, x.Re*y.Im - y.Re*x.Im);
//    }
//    public static bool operator ==(Complex x, Complex y)
//    {
//        return x.Re==y.Re&&x.Im==y.Im;
//    }
//    public static bool operator !=(Complex x, Complex y)
//    {
//        return (x.Re != y.Re&&x.Im == y.Im)||
//                (x.Re == y.Re && x.Im != y.Im) ||
//                (x.Re != y.Re && x.Im != y.Im);
//    }
//}
//class Person
//{
//    public string? Name { get; set; }
//    public Person(string? name)=>Name = name;
//}
//class Company
//{
//    private Person[]? personal;
//    public Company(Person[]? _personal)=>this.personal =_personal;
//    public Person this[int index]
//    {
//        get
//        {
//            if (index >= 0 && index < personal!.Length)
//                return personal![index];
//            else
//                throw new ArgumentOutOfRangeException();
//        }
//        set
//        {
//            if (index >= 0 && index < personal!.Length) personal![index] = value;
//        }
//    }
//}

Console.Write("Введите первое число: ");
double x = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double y = double.Parse(Console.ReadLine()!);
Money x1 = new Money(x);
Money x2 = new Money(y);
Money sum = x1 + x2;
Console.WriteLine("Сумма про сложении = " + sum.Total + " руб");
Money min = x1 - x2;
Console.WriteLine("Сумма про вычитании = " + min.Total + " руб");
Money div = x1 / x2;
Console.WriteLine("Сумма про делении = " + div.Total + " руб");
sum.Dengi();
class Money
{
    public double Total;
    public Money(double sum)
    {
        Total = sum;
    }
    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Total + b.Total);
    }
    public static Money operator -(Money a, Money b)
    {
        return new Money(a.Total - b.Total);
    }
    public static Money operator /(Money a, Money b)
    {
        return new Money(a.Total / b.Total);
    }
    public void Dengi()
    {
        int[] rubl = { 5000, 1000, 500, 100, 50, 10, 5, 2, 1 };
        double[] kopi = { 0.5, 0.1, 0.05, 0.01 };
        int rubles = (int)Total;
        double kopeyki = Total - rubles;
        Console.WriteLine("Купюры:");
        foreach (int n in rubl)
        {
            int count = rubles / n;
            rubles %= n;
            if (count > 0)
                Console.WriteLine($"{n} руб - {count} шт");
        }
        Console.WriteLine("Копейки:");
        foreach (double cop in kopi)
        {
            int count = (int)(kopeyki / cop);
            kopeyki = (kopeyki % cop);

            if (count > 0)
                Console.WriteLine($"{cop.ToString("")} руб - {count} шт");
        }
    }
}