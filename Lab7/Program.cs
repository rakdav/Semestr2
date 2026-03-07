//using System.Collections;

//ArrayList array=new ArrayList();
//array.Add(6);
//array.Add("rest");
//array.Add(7.9);
//array.Add(true);
//array.Add('c');
//foreach(var i in array) Console.Write(i+" ");
//Console.WriteLine();
//Console.WriteLine(array.Count);
//Console.WriteLine(array.Capacity);
//ArrayList array2=new ArrayList(array);
//array2.Add("gfgdf");
//Console.WriteLine(array2.Capacity);
//Console.WriteLine(array2.Count);
//Console.WriteLine(array2[3]);
//array2.Insert(2, "gdfg");
//foreach (var i in array2) Console.Write(i + " ");
//Console.WriteLine();
//array2.RemoveAt(0);
//array2.Remove("gfgdf");
//Console.WriteLine(array2.Contains("rest"));
//Console.WriteLine(array2.IndexOf("rest"));
//Console.WriteLine(array2.LastIndexOf("rest"));
//array2.Clear();

//Queue<string> numbers = new Queue<string>();
//numbers.Enqueue("one");
//numbers.Enqueue("two");
//numbers.Enqueue("three");
//numbers.Enqueue("four");
//numbers.Enqueue("five");

//Console.WriteLine(numbers.Peek());
//Console.WriteLine(numbers.Dequeue());
//Console.WriteLine(numbers.Peek());

//Stack<string> numbs = new Stack<string>();
//numbs.Push("one");
//numbs.Push("two");
//numbs.Push("three");
//numbs.Push("four");
//numbs.Push("five");

//Console.WriteLine(numbs.Peek());
//Console.WriteLine(numbs.Pop());
//Console.WriteLine(numbs.Peek());

//12 вариант
//базовый уровень
//List<int> list = new List<int>();
//Random rand = new Random();
//for (int i = 0; i < rand.Next(30); i++)
//{
//    list.Add(rand.Next(10,100));
//    Console.Write(list[i]);
//}
//int min = list[0];
//int minIndex = 0;
//for (int i = 1; i < list.Count; i++)
//{
//    if (list[i] < min)
//    {
//        minIndex = i;
//        min= list[i];
//    }
//}
//Console.WriteLine(min+" "+minIndex);
//средний уровень
Random rand = new Random();
List<double> list1 = new List<double>();
for (int i = 0;i < 15; i++)
{
    list1.Add(rand.NextDouble()*100-50);
    Console.Write($"{list1[i]:F2} ");
}
List<double> list2 = new List<double>();
foreach (int item in list1)
{
    if (item < -3 && item > 7)
    {
        list2.Add(item);
        Console.Write($"{item:F2} ");
    }
}
double s = 0;
foreach (int item in list2)
    if (item < 0) s += item;
Console.WriteLine($"s={s:F2}");




