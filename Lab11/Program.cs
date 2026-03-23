using Lab11;

//Console.Write("Введите строку:");
//string str=Console.ReadLine()!;
//Console.Write("Введите символ:");
//int code=Console.Read();
//char c=Convert.ToChar(code);
//Console.WriteLine(str.CountWord(c));

List<Car> GetCars()
{
    return new List<Car>
                {
                    new Car { VIN = "ABC123", Make = "Ford",
                            Model = "F-250", Year = 2000 },
                    new Car { VIN = "DEF123", Make = "BMW",
                            Model = "Z-3", Year = 2005 },
                    new Car { VIN = "ABC456", Make = "Audi",
                            Model = "TT", Year = 2008 },
                    new Car { VIN = "HIJ123", Make = "VW",
                            Model = "Bug",  Year = 1956  },
                    new Car { VIN = "DEF456", Make = "Ford",
                            Model = "F-150", Year = 1998 }
                };
}
bool IsOld1960()
{
    int count = 0;
    foreach (Car i in GetCars())
    {
        if (i.Year > 1960) count++;
    }
    return count==GetCars().Count;
}
Console.WriteLine(IsOld1960());
Console.WriteLine(GetCars().All(p=>p.Year>1960));
Console.WriteLine(GetCars().Any(p => p.Year > 1960));
var strings = new MyStringList { "orange", "apple", "grape", "pear" };
foreach (var item in strings.Where(s => s.Length > 5))
{
    Console.Write(item+" ");
}
Console.WriteLine();
var querable = strings.AsQueryable();
Console.WriteLine("Element Type: {0}", querable.ElementType);
Console.WriteLine("Expression: {0}", querable.Expression);
Console.WriteLine("Provider: {0}", querable.Provider);
int[] scores = { 88, 56, 23, 99, 65, 93, 78, 23, 99, 90 };
foreach(int i in scores)
    if(i%2==0) Console.Write(i+" ");
Console.WriteLine();
foreach(var i in scores.Where(i=>i%2!=0).ToArray())
    Console.Write(i+" ");
Console.WriteLine();
var carsByVin = GetCars().ToDictionary(c => c.VIN);
Car myCar = carsByVin["DEF123"];
Console.WriteLine(myCar.VIN+" "+myCar.Model+" "+myCar.Make+" "+myCar.Color);

public class Car
{
    public string? VIN { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? Color { get; set; }
}
public class MyStringList : List<string>
{
    public IEnumerable<string> Where(Predicate<string> filter)
    {
        return this.Select(s => filter(s) ? s.ToUpper() : s);
    }
}



