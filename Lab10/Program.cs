//Dictonary
//Dictionary<int,string> people=new Dictionary<int,string>();
//people.Add(4, "Bob");
//people.Add(5, "Golub");
//people.Add(1, "Nikitin");
//foreach (var person in people)
//    Console.WriteLine($"Key:{person.Key} value:{person.Value}");
//foreach (var (key, val) in people) 
//{
//    Console.WriteLine($"key: {key}  value: {val}");
//}
//Console.WriteLine(people.Count);
//Console.WriteLine(people[4]);
//Console.WriteLine(people.ContainsKey(4));
//Console.WriteLine(people.ContainsValue("Nikitin"));

////Sets
////HashSet
//HashSet<string> fruits = new HashSet<string>();
//fruits.Add("Potato");
//fruits.Add("Banana");
//fruits.Add("Apple");
//fruits.Add("Orange");
//fruits.Add("Banana");
//foreach (var fru in fruits)
//    Console.WriteLine(fru + " " + fru.GetHashCode());
////SortedSet
//SortedSet<string> treeFruit = new SortedSet<string>();
//treeFruit.Add("Potato");
//treeFruit.Add("Banana");
//treeFruit.Add("Apple");
//treeFruit.Add("Orange");
//treeFruit.Add("Banana");
//foreach (var fru in treeFruit) Console.WriteLine(fru);

//SortedSet<int> intTree = new SortedSet<int>();
//intTree.Add(34);
//intTree.Add(12);
//intTree.Add(25);
//intTree.Add(78);
//intTree.Add(64);
//intTree.Add(99);
//foreach (var t in intTree) Console.Write(t + " ");
//Console.WriteLine();

//var set1 = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, };
//var set2 = new SortedSet<int>() { 4, 5, 6, 7, 8, 9 };
//var set3 = new SortedSet<int>() { 2, 3, 4 };
//var union=set1.Union(set2);
//foreach (var t in union) Console.Write(t + " ");
//Console.WriteLine();
//var intersection=set1.Intersect(set2);
//foreach (var t in intersection) Console.Write(t + " ");
//Console.WriteLine();
//var diff=set1.Except(set2);
//foreach (var t in diff) Console.Write(t + " ");
//Console.WriteLine();


//List<int> varinants = new List<int>();
//for (int i = 0; i < 30; i++) varinants.Add(i+1);
//Dictionary<string, int> people = new Dictionary<string, int>();
//HashSet<int> list = new HashSet<int>();
//int n = 1;
//while (n<11)
//{
//    int number = new Random().Next(1, 30);
//    if (!list.Contains(number))
//    {
//        list.Add(number);
//        n++;
//    }
//}
//foreach (int i in list) Console.Write(i+" ");
//Console.WriteLine();
//int j = 1;
//foreach (int i in list)
//{
//    people[(j).ToString()] = i;
//    j++;
//}
//foreach(var (key,value) in people)
//{
//    Console.WriteLine(key+":"+value);
//}

//Вариант 8
//Console.Write("Введите количество учеников в классе:");
//int n=int.Parse(Console.ReadLine()!);
//Group group = new Group(n);
//group.Create();
//group.Print();
//group.HowMany();
//class Person
//{
//    public int Quantity { get; set; }
//    public List<string>? Languages;
//    public Person(int n)
//    {
//        Quantity = n;
//        Languages = new List<string>();
//    }
//    public void Create()
//    {
//        Console.WriteLine("Введите языки:");
//        for (int i = 0; i < Quantity; i++)
//        {
//            string lang=Console.ReadLine()!;
//            Languages!.Add(lang);
//        }
//    }
//    public void Print()
//    {
//        Console.WriteLine("Количество языков:"+Quantity);
//        foreach (var item in Languages!)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

//class Group
//{
//    private int Count;
//    public List<Person>? persons;
//    public Group(int n)
//    {
//        Count = n;
//        persons = new List<Person>();
//    }
//    public void Create()
//    {
//        for (int i = 0; i < Count; i++)
//        {
//            Console.Write("Сколько языков знает ученик:");
//            int n=int.Parse(Console.ReadLine()!);
//            Person p=new Person(n);
//            p.Create();
//            persons!.Add(p);
//        }
//    }
//    public void Print()
//    {
//        foreach(Person i in persons!) i.Print();
//    }
//    public void HowMany()
//    {
//        SortedSet<string> s = new SortedSet<string>();
//        foreach(Person i in persons!)
//        {
//            foreach (string s2 in i.Languages!)
//            {
//                s.Add(s2.ToLower());
//            }
//        }
//        Console.WriteLine("Все школьники:"+s.Count);
//        foreach(string s2 in s) Console.WriteLine(s2+" ");
//    }
//}
Console.Write("Введите количество слов:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите слова в формате: сначала английское слово, затем отделённый пробелами дефис, затем разделённые запятыми с пробелами переводы этого английского слова на латинский.");
Dictionary<string,List<string>> LatEng=new Dictionary<string,List<string>>();
for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    string s = Console.ReadLine()!;
    string[] one=s.Split(" - ");
    string key=one[0];
    List<string> values=one[1].Split(", ").ToList();
    values.Sort();
    LatEng.Add(key, values);
}
foreach(var (k,v) in LatEng)
{
    Console.Write(k+":");
    foreach(string m in v) Console.Write(m+" ");
    Console.WriteLine();
}
Console.Write("Введите слово:");
string word=Console.ReadLine()!;
foreach(var (k, v) in LatEng)
{
    if(k==word)
        foreach (string m in v) Console.Write(m + " ");
}


