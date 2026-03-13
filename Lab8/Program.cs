//Вариант 18. Базовый уровень
Stack<int> stack= new Stack<int>();
int n = new Random().Next(10,20);
for (int i = 0; i < n; i++)
{
    stack.Push(new Random().Next(10,100));
}
foreach(int i in stack) Console.Write(i+" ");
Console.WriteLine();
double s = 0;
foreach (int i in stack) if (i%2==0) s += i;
Console.WriteLine($"Avg={(s/stack.Count):F2}");
//Вариант 18. Средний уровень
Stack<string> stack2= new Stack<string>();
stack2.Push("Students");
stack2.Push("of");
stack2.Push("the");
stack2.Push("group");
stack2.Push("TE");
stack2.Push("3");
foreach (string i in stack2) Console.Write(i + " ");
Console.WriteLine();
stack2.Pop();
foreach (string i in stack2) Console.Write(i + " ");
Console.WriteLine();
foreach (string i in stack2)
    if(i.Length==2) Console.Write(i + " ");



