using Lab11;
using System;

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
//bool IsOld1960()
//{
//    int count = 0;
//    foreach (Car i in GetCars())
//    {
//        if (i.Year > 1960) count++;
//    }
//    return count==GetCars().Count;
//}
//Console.WriteLine(IsOld1960());
//Console.WriteLine(GetCars().All(p=>p.Year>1960));
//Console.WriteLine(GetCars().Any(p => p.Year > 1960));
//var strings = new MyStringList { "orange", "apple", "grape", "pear" };
//foreach (var item in strings.Where(s => s.Length > 5))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//var querable = strings.AsQueryable();
//Console.WriteLine("Element Type: {0}", querable.ElementType);
//Console.WriteLine("Expression: {0}", querable.Expression);
//Console.WriteLine("Provider: {0}", querable.Provider);
//int[] scores = { 88, 56, 23, 99, 65, 93, 78, 53, 99, 90 };
//foreach(int i in scores)
//    if(i%2==0) Console.Write(i+" ");
//Console.WriteLine();
//foreach(var i in scores.Where(i=>i%2!=0).ToArray())
//    Console.Write(i+" ");
//Console.WriteLine();
//var carsByVin = GetCars().ToDictionary(c => c.VIN);
//Car myCar = carsByVin["DEF123"];
//Console.WriteLine(myCar.VIN+" "+myCar.Model+" "+myCar.Make+" "+myCar.Color);
//Console.WriteLine(scores.Max());
//Console.WriteLine(scores.Min());
//Console.WriteLine(scores.Average());
//Console.WriteLine(scores.Sum());
//Console.WriteLine(scores.Count());
//Console.WriteLine(scores[7]);
//Console.WriteLine(scores.ElementAt(7));
//Console.WriteLine(scores.First());
//Console.WriteLine(scores.Last());
//Console.WriteLine(scores.ElementAtOrDefault(17));
//Console.WriteLine(scores.FirstOrDefault());
//Console.WriteLine(scores.LastOrDefault());
//Console.WriteLine(scores.Where(x =>x>100).SingleOrDefault());
//Console.WriteLine(scores.DefaultIfEmpty());
//Console.WriteLine(scores.Contains(65));
//foreach(int i in scores.Distinct())
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();

//int[] lastYearScores = { 88, 56, 23, 99, 65 };
//int[] thisYearScores = { 93, 78, 23, 99, 90 };
//foreach (var item in lastYearScores.Concat(thisYearScores))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//foreach (var item in lastYearScores.Except(thisYearScores))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();

//foreach (var item in lastYearScores.Intersect(thisYearScores))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//var allScores = lastYearScores.Union(thisYearScores);
//foreach (var item in allScores.OrderBy(s => s))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//foreach (var score in scores.Reverse())
//{
//    Console.Write(score+" ");
//}
//Console.WriteLine();
//List<int> lastYearScoresList = new List<int> { 93, 78, 23, 99, 91 };
//List<int> thisYearScoresList = new List<int> { 93, 78, 23, 99, 90 };

//Console.WriteLine(lastYearScoresList.SequenceEqual(thisYearScoresList));
//lastYearScoresList[4] = 90;
//Console.WriteLine(lastYearScoresList.SequenceEqual(thisYearScoresList));
//foreach (var s in scores.OrderBy(i => i).Skip(9))
//{ Console.Write(s+" "); }
//Console.WriteLine();
//foreach (var s in scores.OrderBy(i => i).SkipWhile(s => s < 80))
//{ Console.Write(s+" "); }
//Console.WriteLine();
//foreach (var s in scores.SkipWhile(s => s < 80))
//{ Console.Write(s+" "); }
//Console.WriteLine();
//foreach (var item in scores.OrderBy(i => i).Skip(3).Take(2))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//foreach (var item in scores.OrderBy(i => i).TakeWhile(s => s < 80))
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//var numbers = Enumerable.Range(1, 1000);
//var cars = GetCars();
//var zip = numbers.Zip(cars, (i, c) => new
//{
//    Number = i,
//    CarMake = c.Make
//});
//foreach (var it in zip)
//{
//    Console.WriteLine("Number:{0} Make:{1}", it.Number, it.CarMake);
//}
//Random rand = new Random();
//int[] mas = new int[10];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rand.Next(10, 100);
//}
//mas = mas.Select(i => i + rand.Next(1,10)).ToArray();
//foreach (int i in mas) Console.Write(i + " ");
//Console.WriteLine();
//mas=mas.Select(i => i *2).ToArray();
//foreach (int i in mas) Console.Write(i + " ");
//Console.WriteLine();
//Console.Write("Введите а:");
//int a=int.Parse(Console.ReadLine()!);
//mas = mas.Select(i => i-a).ToArray();
//foreach (int i in mas) Console.Write(i + " ");
//Console.WriteLine();
//mas = mas.Select(i => i / mas.ElementAt(0)).ToArray();
//foreach (int i in mas) Console.Write(i + " ");
//Console.WriteLine();
//Console.WriteLine(mas.Where(p=>p%2==0).Sum());
//Console.WriteLine(mas.Aggregate((x,y)=>x*y));
//Console.WriteLine(mas.Select(i=>i*i).Sum());
//Console.WriteLine(mas.Take(6).Sum());
//int k1 = int.Parse(Console.ReadLine()!);
//int k2 = int.Parse(Console.ReadLine()!);
//Console.WriteLine(mas.Where((i,k)=>k>k1&&k<k2).Sum());
//Console.WriteLine(mas.Average());
//Console.WriteLine(mas.Aggregate((x, y) => (y%2==0)?x+y:x-y));

//Операторы запросов LINQ
//var cars1 =from car in GetCars()
//          select car;
//foreach (var car in cars1)
//    Console.WriteLine(car.Model+" "+car.VIN+" "+car.Make+" "+car.Color+" "+car.Year);
//var cars2 = from car in GetCars()
//            select new { Model=car.Model,Year=car.Year};
//foreach (var car in cars2)
//    Console.WriteLine(car.Model + " "+ car.Year);
//var cars3 = from car in GetCars()
//            where car.Model =="BMW"
//            select new { Model = car.Model, Year = car.Year };
//foreach (var car in cars3)
//    Console.WriteLine(car.Model + " " + car.Year);
//var cars4 = from car in GetCars()
//            where car.Model == "Ford"&&car.Year >=2000
//            select new { Model = car.Model, Year = car.Year };
//foreach (var car in cars4)
//    Console.WriteLine(car.Model + " " + car.Year);
//var cars5=from car in GetCars() 
//          orderby car.Year
//          select car;
//foreach (var car in cars5)
//    Console.WriteLine(car.Model + " " + car.Year);
//var cars6 = from car in GetCars()
//            orderby car.Year descending
//            select car;
//foreach (var car in cars6)
//    Console.WriteLine(car.Model + " " + car.Year);
//var cars7 = from car in GetCars()
//            orderby car.Year,car.Color
//            select car;
//foreach (var car in cars7)
//    Console.WriteLine(car.Model + " " + car.Year);
//var cars8 = from car in GetCars()
//            group car by car.Make;
//foreach (var car in cars8)
//{
//    Console.WriteLine(car.Key);
//    foreach (var c in car)
//    {
//        Console.WriteLine(c.Year+" "+c.VIN+" "+c.Color+" "+c.Model);
//    }
//}
//var cars9 = from car in GetCars()
//            let model = car.Model
//            let year = car.Year
//            select new
//            {
//                Model=model,
//                Year=year
//            };
//foreach (var car in cars9)
//    Console.WriteLine(car.Year +" " + car.Model);
//Console.WriteLine();
////Методы расширения LINQ
//List<Car> carsList1=GetCars().ToList();
//var carsList2=GetCars().Select(p=>new { Model = p.Model, Year = p.Year }).ToList();
//foreach (var car in carsList2)
//    Console.WriteLine(car.Model + " " + car.Year);
//var carsList3 = GetCars().Where(p=>p.Model== "BMW").Select(p => new { Model = p.Model, Year = p.Year }).ToList();
//var carsList4 = GetCars().Where(p => p.Model == "FORD"&&p.Year>=2000).Select(p => new { Model = p.Model, Year = p.Year }).ToList();
//var carsList5 = GetCars().OrderBy(p => p.Year).ToList();
//var carsList6 = GetCars().OrderByDescending(p => p.Year).ToList();
//var carsList7 = GetCars().OrderBy(p => p.Year).ThenBy(p=>p.Color).ToList();
//var carsList8 =GetCars().GroupBy(p => p.Make).ToList();
//foreach (var car in carsList8)
//{
//    Console.WriteLine(car.Key);
//    foreach (var c in car)
//    {
//        Console.WriteLine(c.Year + " " + c.VIN + " " + c.Color + " " + c.Model);
//    }
//}

Person[] people =
{
    new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
    new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
};

Company[] companies =
{
    new Company("Microsoft", "C#"),
    new Company("Google", "Go"),
    new Company("Oracle", "Java")
};
record class Person(string Name, string Company);
record class Company(string Title, string Language);
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


