//Person tom=new Person("Tom",23,new Company("Samsung"));
//Person bob = (Person)tom.Clone();
//Console.WriteLine(tom);
//Console.WriteLine(bob);
//bob.Name = "Vasya";
//bob.Company.Name = "Sony";
//Console.WriteLine(tom);
//Console.WriteLine(bob);
//Person john = new Person("John", 45, new Company("Yamaha"));
//Person[] people = {tom, bob, john};
//Array.Sort(people);
//Console.WriteLine();
//foreach (var item in people)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();
//Array.Sort(people, new PeopleCompareByAge());
//foreach (var item in people)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();
//Array.Sort(people, new PeopleCompareByCompany());
//foreach (var item in people)
//{
//    Console.WriteLine(item);
//}

using System.Collections;

//string[] people = {"Tom","Sam","Bob"};
//IEnumerator peopleEnumerator=people.GetEnumerator();
//while (peopleEnumerator.MoveNext())
//{
//    Console.WriteLine((string)peopleEnumerator.Current);
//}
//peopleEnumerator.Reset();

Week week=new Week();
foreach(var day in week) Console.WriteLine(day);

class WeekEnumerator : IEnumerator
{
    string[] days;
    int position = -1;
    public WeekEnumerator(string[] days)=>this.days = days;
    public object Current {
        get {
            if (position == -1 || position >= days.Length)
                throw new ArgumentException();
            return days[position];
        }
    }
    public bool MoveNext()
    {
        if (position < days.Length - 1)
        {
            position++;
            return true;
        }
        else 
            return false;
    }
    public void Reset()=>position = -1;
}
class Week
{
    string[] days = {"Sunday","Monday","Tuesday","Wednesday", "Thursday",
                            "Friday", "Saturday"};
    public IEnumerator GetEnumerator()=>new WeekEnumerator(days);
}
class Person :ICloneable,IComparable
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
    public int CompareTo(object? obj)
    {
        if (obj is Person person) return Name!.CompareTo(person.Name);
        else throw new ArgumentException("Некорректное значение");
    }
}
class Company
{
    public string? Name { get; set; }
    public Company(string? name)=>Name = name;
}
class PeopleCompareByAge : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if (x is null || y is null)
            throw new ArgumentException("Некорректные значения");
        return x.Age.CompareTo(y.Age);
    }
}
class PeopleCompareByCompany : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if (x is null || y is null)
            throw new ArgumentException("Некорректные значения");
        return x.Company.Name!.CompareTo(y.Company.Name);
    }
}