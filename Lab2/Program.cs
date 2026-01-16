//Complex z1=new Complex(1, 2);
//Complex z2=new Complex(2, 8);
//Complex z3=z1+z2;
//Console.WriteLine(z3);
//Complex z4 = z1 - z2;
//Console.WriteLine(z4);
//Complex z5 = z1 * z2;
//Console.WriteLine(z5);
//Console.WriteLine(z4==z5);
Person[] person = new Person[4];
person[0] = new Person("One");
person[1] = new Person("Two");
person[2] = new Person("Three");
person[3] = new Person("Four");
Company company = new Company(person);
Person p = company[2];
Console.WriteLine(p.Name);
class Complex
{
    public double Re {  get; set; }
    public double Im { get; set; }
    public Complex(double re, double im)
    {
        Re = re;
        Im = im;
    }
    public override string? ToString()
    {
        return "Z="+Re+((Im>=0)?"+":"")+Im+"i";
    }
    public static Complex operator + (Complex x, Complex y)
    {
        return new Complex(x.Re+y.Re,x.Im+y.Im);
    }
    public static Complex operator - (Complex x, Complex y)
    {
        return new Complex(x.Re - y.Re, x.Im - y.Im);
    }
    public static Complex operator * (Complex x, Complex y)
    {
        return new Complex(x.Re*y.Re - x.Im*y.Im, x.Re*y.Im - y.Re*x.Im);
    }
    public static bool operator ==(Complex x, Complex y)
    {
        return x.Re==y.Re&&x.Im==y.Im;
    }
    public static bool operator !=(Complex x, Complex y)
    {
        return (x.Re != y.Re&&x.Im == y.Im)||
                (x.Re == y.Re && x.Im != y.Im) ||
                (x.Re != y.Re && x.Im != y.Im);
    }
}
class Person
{
    public string? Name { get; set; }
    public Person(string? name)=>Name = name;
}
class Company
{
    private Person[]? personal;
    public Company(Person[]? _personal)=>this.personal =_personal;
    public Person this[int index]
    {
        get
        {
            if (index >= 0 && index < personal!.Length)
                return personal![index];
            else
                throw new ArgumentOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < personal!.Length) personal![index] = value;
        }
    }
}