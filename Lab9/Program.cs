using System.Collections;
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
