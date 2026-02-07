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

//using System.Collections;

//string[] people = {"Tom","Sam","Bob"};
//IEnumerator peopleEnumerator=people.GetEnumerator();
//while (peopleEnumerator.MoveNext())
//{
//    Console.WriteLine((string)peopleEnumerator.Current);
//}
//peopleEnumerator.Reset();

//Week week=new Week();
//foreach(var day in week) Console.WriteLine(day);

//class WeekEnumerator : IEnumerator
//{
//    string[] days;
//    int position = -1;
//    public WeekEnumerator(string[] days)=>this.days = days;
//    public object Current {
//        get {
//            if (position == -1 || position >= days.Length)
//                throw new ArgumentException();
//            return days[position];
//        }
//    }
//    public bool MoveNext()
//    {
//        if (position < days.Length - 1)
//        {
//            position++;
//            return true;
//        }
//        else 
//            return false;
//    }
//    public void Reset()=>position = -1;
//}
//class Week
//{
//    string[] days = {"Sunday","Monday","Tuesday","Wednesday", "Thursday",
//                            "Friday", "Saturday"};
//    public IEnumerator GetEnumerator()=>new WeekEnumerator(days);
//}
//class Person :ICloneable,IComparable
//{
//    public string? Name { get; set; }
//    public int Age {  get; set; }
//    public Company Company { get; set; }
//    public Person(string? name, int age,Company company)
//    {
//        Name = name;
//        Age = age;
//        Company = company;
//    }
//    public override string? ToString()
//    {
//        return $"Name:{Name} Age:{Age} Company:{Company.Name}";
//    }
//    public object Clone()
//    {
//        return new Person(Name, Age,new Company(Company.Name));
//       // return MemberwiseClone();
//    }
//    public int CompareTo(object? obj)
//    {
//        if (obj is Person person) return Name!.CompareTo(person.Name);
//        else throw new ArgumentException("Некорректное значение");
//    }
//}
//class Company
//{
//    public string? Name { get; set; }
//    public Company(string? name)=>Name = name;
//}
//class PeopleCompareByAge : IComparer<Person>
//{
//    public int Compare(Person? x, Person? y)
//    {
//        if (x is null || y is null)
//            throw new ArgumentException("Некорректные значения");
//        return x.Age.CompareTo(y.Age);
//    }
//}
//class PeopleCompareByCompany : IComparer<Person>
//{
//    public int Compare(Person? x, Person? y)
//    {
//        if (x is null || y is null)
//            throw new ArgumentException("Некорректные значения");
//        return x.Company.Name!.CompareTo(y.Company.Name);
//    }
//}

//BankAccount b1=new BankAccount("my1","qwerty");
//BankAccount b2 = new BankAccount("my1", 1234);
//string p1=(string)b1.Password!;
//int p2=(int)b2.Password!;
//class BankAccount
//{
//    public string? Login { get;}
//    public object? Password { get;}

//    public BankAccount(string? login, object? password)
//    {
//        Login = login;
//        Password = password;
//    }
//}
//class BankAccountString
//{
//    public string? Login { get; set; }
//    public string? Password { get; set; }
//}
//BankAccount<int,string> bankInt = new BankAccount<int,string>("qwerty",1234);
//bankInt.Login = "qwerty";
//bankInt.Password = 1234;
//BankAccount<string,int> bankString = new BankAccount<string,int>(1234, "qwerty");
//bankString.Login = 1234;
//bankString.Password = "qwerty";
//class BankAccount<T,K>
//{
//    public K? Login { get; set; }
//    public T? Password { get; set; }

//    public BankAccount(K? login, T? password)
//    {
//        Login = login;
//        Password = password;
//    }
//}

//void Swap<T>(ref T x,ref T y)
//{
//    T temp = x; 
//    x=y; 
//    y=temp;
//}
//int x=5, y=10;
//Console.WriteLine(x +" "+y);
//Swap<int>(ref x,ref y);
//Console.WriteLine(x + " " + y);

//double z = 5, v = 10;
//Console.WriteLine(z +" "+v);
//Swap<double>(ref z,ref v);
//Console.WriteLine(z+" "+v);

//string str1 = "ewqe", str2 = "rtee";
//Console.WriteLine(str1 +" "+str2);
//Swap<string>(ref str1,ref str2);
//Console.WriteLine(str1+" "+str2);
//void SendMessage<T>(T message) where T : Message
//{
//    Console.WriteLine($"Отправляется сообщение: {message.Text}");
//}
//SendMessage(new Message("Hello World"));
//SendMessage(new EmailMessage("Bye World"));
//class Message
//{
//    public string Text { get; } // текст сообщения
//    public Message(string text)
//    {
//        Text = text;
//    }
//}

//class EmailMessage : Message
//{
//    public EmailMessage(string text) : base(text) { }
//}

//class SMSMessage : Message
//{
//    public SMSMessage(string text) : base(text) { }
//}

//class TelegramMessage : Message
//{
//    public TelegramMessage(string text) : base(text) { }
//}
//Person<string> person1 = new Person<string>("34");
//Person<int> person3 = new UniversalPerson<int>(45);
//UniversalPerson<int> person2 = new UniversalPerson<int>(33);
//Console.WriteLine(person1.Id);
//Console.WriteLine(person2.Id);
//Console.WriteLine(person3.Id);

//class Person<T>
//{
//    public T Id { get; }
//    public Person(T id)
//    {
//        Id = id;
//    }
//}
//class UniversalPerson<T> : Person<T>
//{
//    public UniversalPerson(T id) : base(id) { }
//}
using System.Collections;

Console.Write("Введите количество поездов:");
int n=int.Parse(Console.ReadLine()!);
Train<int>[] trains=new Train<int>[n];
for (int i = 0; i < trains.Length; i++)
{
    Console.Write("Введите номер поезда:");
    int number=int.Parse(Console.ReadLine()!);
    Console.Write("Введите станцию назначения:");
    string dest = Console.ReadLine()!;
    Console.Write("Введите время отправления:");
    TimeOnly time = TimeOnly.Parse(Console.ReadLine()!);
    trains[i]=new Train<int>(number, dest, time);
}
Array.Sort(trains);
foreach (var item in trains) Console.WriteLine(item);
Console.WriteLine();
Array.Sort(trains,new TrainCompareByTimeInt());
foreach (var item in trains) Console.WriteLine(item);
Console.WriteLine();
RaiwayStation<int> rw = new RaiwayStation<int>(trains);
Console.Write("Введите время:");
TimeOnly timeDest = TimeOnly.Parse(Console.ReadLine()!);
rw.TrainsByTime(timeDest);
class RaiwayStation<T>
{
    private Train<T>[] trains;
    public RaiwayStation(Train<T>[] _train)
    {
        trains = _train;
    }
    public void TrainsByTime(TimeOnly time)
    {
        //for (int i = 0; i < trains.Length; i++)
        //{
        //    if (trains[i].Time>time) Console.WriteLine(trains[i]);
        //}
        
    }
}
class Train<T>:ICloneable,IComparable
{
    public T Number { get; }
    public string? Dest { get; set; }
    public TimeOnly Time { get; set; }
    public Train(T number, string? dest, TimeOnly time)
    {
        Number = number;
        Dest = dest;
        Time = time;
    }
    public object Clone()
    {
        return new Train<T>(Number,Dest,Time);
    }
    public int CompareTo(object? obj)
    {
        if (obj is Train<T> train) return Dest!.CompareTo(train.Dest);
                else throw new ArgumentException("Некорректное значение");
    }
    public override string? ToString()
    {
        return $"Номер:{Number}, пункт назначения:{Dest}, время отправления:{Time}";
    }
}
class TrainCompareByTimeString : IComparer<Train<string>>
{
    public int Compare(Train<string>? x, Train<string>? y)
    {
        if(x is null || y is null)
            throw new ArgumentException("Некорректные значения");
        return x.Time!.CompareTo(y.Time);
    }
}
class TrainCompareByTimeInt : IComparer<Train<int>>
{
    public int Compare(Train<int>? x, Train<int>? y)
    {
        if (x is null || y is null)
            throw new ArgumentException("Некорректные значения");
        return x.Time!.CompareTo(y.Time);
    }
}

class RailwayStationEnumerator<T> : IEnumerator<Train<T>>
{
    private Train<T>[] trains;
    private int position=-1;
    private Train<T> current;
    public RailwayStationEnumerator(Train<T>[] _trains)
    {
        this.trains =_trains;
        current=default(Train<T>);
    }

    public Train<T> Current
    {
        get 
        {
            if (position < 0 || position > trains.Length)
                throw new InvalidOperationException();
            return current;
        }
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        position++;
        if (position <= trains.Length)
        {
            current = trains[position];
            return true;
        }
        current = default(Train<T>);
        return false;
    }

    public void Reset()
    {
        position = -1;
        current = default(Train<T>);
    }
}