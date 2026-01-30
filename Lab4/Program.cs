Person tom=new Person("Tom",23,new Company("Samsung"));
Person bob = (Person)tom.Clone();
Console.WriteLine(tom);
Console.WriteLine(bob);
bob.Name = "Vasya";
bob.Company.Name = "Sony";
Console.WriteLine(tom);
Console.WriteLine(bob);
class Person:ICloneable
{
    public string? Name { get; set; }
    public int Age {  get; set; }
    public Company Company { get; set; }
    public Person(string? name, int age,Company company)
    {
        Name = name;
        Age = age;
        Company = company;
    }
    public override string? ToString()
    {
        return $"Name:{Name} Age:{Age} Company:{Company.Name}";
    }

    public object Clone()
    {
        return new Person(Name, Age,new Company(Company.Name));
       // return MemberwiseClone();
    }
}
class Company
{
    public string? Name { get; set; }
    public Company(string? name)=>Name = name;
}
