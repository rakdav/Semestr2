using Lab9;
using System.Collections;
using System.Collections.Generic;
//Связный список
//LinkedList<string> list = new LinkedList<string>();
//list.Add("one");
//list.Add("two");
//list.Add("three");
//list.Add("four");
//foreach (string item in list) Console.Write(item+" ");
//Console.WriteLine();
//list.Remove("one");
//foreach (string item in list) Console.Write(item + " ");
//Console.WriteLine();
//list.AppendFirst("seven");
//foreach (string item in list) Console.Write(item + " ");
//Console.WriteLine();
//list.Add("eight");
//foreach (string item in list) Console.Write(item + " ");
//Console.WriteLine();
//Console.WriteLine(list.Contains("three"));
//public class Node<T>
//{
//    public T? Data {  get; set; }
//    public Node<T>? Next { get; set; }
//    public Node(T? data)
//    {
//        Data = data;
//    }
//}
//public class LinkedList<T> : IEnumerable<T>
//{
//    Node<T>? head;
//    Node<T>? tail;
//    int count;
//    public void Add(T data)
//    {
//        Node<T> node = new Node<T>(data);
//        if (head == null)
//        {
//            head = node;
//        }
//        else tail!.Next= node;
//        tail= node;
//        count++;
//    }
//    public bool Remove(T data)
//    {
//        Node<T>? current = head;
//        Node<T>? previus = null;
//        while (current!=null&&current.Data!=null)
//        {
//            if (current.Data.Equals(data))
//            {
//                if(previus!=null)
//                {
//                    previus!.Next = current.Next;
//                    if (current.Next == null) tail = previus;
//                }
//                else
//                {
//                    head=head!.Next;
//                    if (head == null) tail = null;
//                }
//                count--;
//                return true;
//            }
//            previus = current;
//            current = current.Next;
//        }
//        return false;
//    }
//    public int Count {  get { return count; } }
//    public bool IsEmpty { get { return count == 0; } }
//    public void Clear()
//    {
//        head = null;
//        tail = null;
//        count = 0;
//    }
//    public bool Contains(T data)
//    {
//        Node<T>? current=head;
//        while(current!=null && current.Data!=null)
//        {
//            if (current.Data.Equals(data)) return true;
//            current = current.Next;
//        }
//        return false;
//    }
//    public void AppendFirst(T data)
//    {
//        Node<T> node=new Node<T>(data);
//        node.Next=head;
//        head = node;
//        if(count==0)
//            tail=head;
//        count++;
//    }
//    public IEnumerator<T> GetEnumerator()
//    {
//        Node<T>? current = head;
//        while(current != null)
//        {
//            yield return current.Data!;
//            current = current.Next;
//        }
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return ((IEnumerable<T>)this).GetEnumerator();
//    }
//}

//Двусвязные списки
//DoublyLinkedList<string> linkList=new DoublyLinkedList<string>();
//linkList.Add("Serge");
//linkList.Add("Gnome");
//linkList.Add("MaxicBaev");
//foreach (string link in linkList) Console.Write(link+" ");
//Console.WriteLine();
//linkList.Remove("Gnome");
//foreach(var t in linkList.BackEnumerator())
//    Console.Write(t+" ");
//Console.WriteLine();

//Двухсвязный список LinkedList<T>
//LinkedList<int> numbers=new LinkedList<int>();
//for (int i = 0; i < new Random().Next(10,20); i++)
//    numbers.AddLast(i);
//Console.WriteLine(numbers.Count);
//Console.WriteLine(numbers.First?.Value);
//Console.WriteLine(numbers.Last?.Value);
//numbers.AddAfter(numbers.First!,7);
//numbers.AddBefore(numbers.Last!,78);
//numbers.RemoveFirst();
//numbers.RemoveLast();
//foreach (var item in numbers) Console.Write(item+" ");
//Console.WriteLine();

//var currentNode=numbers.First;
//while (currentNode != null)
//{
//    Console.Write(currentNode.Value+" ");
//    currentNode=currentNode.Next;
//}
//Console.WriteLine();
//currentNode = numbers.Last;
//while (currentNode != null)
//{
//    Console.Write(currentNode.Value+" ");
//    currentNode = currentNode.Previous;
//}
//Console.WriteLine();

//6 вариант. Базовый уровень.
//OurLinkedList list =new OurLinkedList();
//Random random=new Random(); 
//for(int i=0; i < random.Next(10, 20); i++)
//{
//    list.Add(random.Next(100));
//}
//list.Print();
//double find=double.Parse(Console.ReadLine()!);
//list.PrevRemove(find);
//list.Print();

//public class Node
//{
//    public Node(double data)
//    {
//        Data = data;
//    }
//    public double Data { get; set; }
//    public Node Next { get; set; }
//}

//public class OurLinkedList  // односвязный список
//{
//    Node? head; // головной/первый элемент
//    Node? tail; // последний/хвостовой элемент
//    int count;  // количество элементов в списке

//    // добавление элемента
//    public void Add(double data)
//    {
//        Node node = new Node(data);

//        if (head == null)
//            head = node;
//        else
//            tail!.Next = node;
//        tail = node;

//        count++;
//    }
//    public void PrevRemove(double data)
//    {
//        if(head==null||head.Next==null) return;
//        if(head.Data==data) return;
//        if (head.Next.Data == data)
//        {
//            head=head.Next;
//            return;
//        }
//        Node current=head;
//        while(current.Next != null&&current.Next.Next!=null)
//        {
//            if (current.Next.Next.Data == data)
//            {
//                current.Next = current.Next.Next;
//                return;
//            }
//            current = current.Next;
//        }
//    }
//    public void Print()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("Список пуст");
//            return;
//        }

//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.Data + " ");
//            current = current.Next;
//        }
//        Console.WriteLine();
//    }
//}

//6 вариант. Средний уровень.
OurLinkedList list = new OurLinkedList();
Random random = new Random();
for (int i = 0; i < random.Next(10, 20); i++)
{
    list.Add(random.Next(100));
}
list.Print();
double find = double.Parse(Console.ReadLine()!);
list.Dublicate(find);
list.Print();
public class Node
{
    public Node(double data)
    {
        Data = data;
    }
    public double Data { get; set; }
    public Node Next { get; set; }
}

public class OurLinkedList  // односвязный список
{
    Node? head; // головной/первый элемент
    Node? tail; // последний/хвостовой элемент
    int count;  // количество элементов в списке

    // добавление элемента
    public void Add(double data)
    {
        Node node = new Node(data);

        if (head == null)
            head = node;
        else
            tail!.Next = node;
        tail = node;

        count++;
    }
    public bool Dublicate(double data)
    {
        Node current = head;
        while (current!=null&&!current.Data.Equals(data))
        {
           current = current.Next;
        }
        if (current == null)
        {
           return false;
        }
        Node copyNode= new Node(data);
        copyNode.Next = current.Next;
        current.Next = copyNode;
        count++;
        return true;
    }
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Список пуст");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}