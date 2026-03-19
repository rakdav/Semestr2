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
//HashSet<string> fruits=new HashSet<string>();
//fruits.Add("Potato");
//fruits.Add("Banana");
//fruits.Add("Apple");
//fruits.Add("Orange");
//fruits.Add("Banana");
//foreach (var fru in fruits)
//    Console.WriteLine(fru+" "+fru.GetHashCode());
////SortedSet
//SortedSet<string> treeFruit=new SortedSet<string>();
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
//foreach (var t in intTree) Console.Write(t+" ");
//Console.WriteLine();

List<int> varinants = new List<int>();
for (int i = 0; i < 30; i++) varinants.Add(i+1);
Dictionary<string, int> people = new Dictionary<string, int>();
HashSet<int> list = new HashSet<int>();
int n = 1;
while (n<11)
{
    int number = new Random().Next(1, 30);
    if (!list.Contains(number))
    {
        list.Add(number);
        n++;
    }
}
foreach (int i in list) Console.Write(i+" ");
Console.WriteLine();
int j = 1;
foreach (int i in list)
{
    people[(j).ToString()] = i;
    j++;
}
foreach(var (key,value) in people)
{
    Console.WriteLine(key+":"+value);
}




