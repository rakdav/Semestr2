using Lab6;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
//одиночные делегаты

//Calculator calc=new Calculator();
//Console.Write("Введите выражение:");
//string exp=Console.ReadLine()!;
//char sign = ' ';
//foreach(char c in exp)
//{
//    if(c == '+'||c=='-'||c=='*'||c=='/')
//    {
//        sign = c;
//        break;
//    }
//}
//try
//{
//    string[] numbers=exp.Split(sign);
//    CalcDelegate del=null;
//    switch (sign)
//    {
//        case '+':
//            del = new CalcDelegate(calc.Add);
//            break;
//        case '-':
//            // del = new CalcDelegate(calc.Sub);
//            del = new CalcDelegate(Calculator.Sub);
//            break;
//        case '*':
//            del = new CalcDelegate(calc.Mult);
//            break;
//        case '/':
//            del = new CalcDelegate(calc.Div);
//            break;
//        default:
//            throw new InvalidOperationException();
//    }
//    Console.WriteLine($"Result:{del(double.Parse(numbers[0]), double.Parse(numbers[1]))}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//цепочки делегатов

//Calculator calc=new Calculator();
//CalcDelegate delAll = calc.Add;
//delAll += calc.Sub;
//delAll += calc.Mult;
//delAll += calc.Div;
//delAll -= calc.Div;
//Console.Write("Введите число a:");
//double a=double.Parse(Console.ReadLine()!);
//Console.Write("Введите число b:");
//double b = double.Parse(Console.ReadLine()!);
//foreach(CalcDelegate item in delAll.GetInvocationList())
//{
//    try
//    {
//        Console.WriteLine($"Result:{item(a,b)}");
//    }
//    catch(Exception ex) 
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

//обобщенные делегаты
//ExampleClass example=new ExampleClass();
//AddDelegate<int> delInt=example.AddInt;
//Console.WriteLine(delInt(6,9));
//AddDelegate<double> delDouble = example.AddDouble;
//Console.WriteLine(delDouble(7.9, 9.1));
//AddDelegate<char> delChar = ExampleClass.AddChar;
//Console.WriteLine(delChar('t', 'k'));

//Делегаты как параметры функции
//double Integrate(double a, double b, int n, RealFunc f)
//{
//    double dx=(b-a)/n;
//    double res = 0.0;
//    for (int j = 0; j < n; j++)
//        res += f(a + j * dx) * dx;
//    return res;
//}
//Console.WriteLine($"{Integrate(0,90,5,Math.Sin):F2}");
//Console.WriteLine($"{Integrate(0, 90, 5, Math.Cos):F2}");
//Console.WriteLine($"{Integrate(0, 90, 5, Math.Tan):F2}");
//public delegate double CalcDelegate(double x,double y);
//public delegate T AddDelegate<T>(T x,T y);
//public delegate double RealFunc(double x);

//Action
//void DoOperation(int a, int b, Action<int, int> op) => op(a, b);
//void Add(int x,int y)=>Console.WriteLine(x + y);
//void Mult(int x, int y) => Console.WriteLine(x * y);
//void Sub(int x, int y) => Console.WriteLine(x - y);
//DoOperation(10, 7, Add);
//DoOperation(11, 8, Mult);
//DoOperation(12, 9, Sub);

//Func
//int DoOperation(int n,Func<int, int> operation)=>operation(n);
//int DoubleNumber(int n) => 2 * n;
//int SquareNumber(int n) => n * n;
//Console.WriteLine(DoOperation(6,DoubleNumber));
//Console.WriteLine(DoOperation(9,SquareNumber));

//Predicate
//Predicate<int> IsPositive=(int x)=>x > 0;
//Console.WriteLine(IsPositive(20));
//Console.WriteLine(IsPositive(-20));
//Console.WriteLine(IsPositive(0));

//Анонимные методы
//MessageHandler handler = delegate (string msg)
//{
//    Console.WriteLine(msg);
//};
//handler("Hello, world!");
//void ShowMessage(string message,MessageHandler handler)
//{
//    handler(message);
//}

//ShowMessage("Heelo", delegate (string mes)
//{
//    Console.WriteLine(mes);
//});
//delegate void MessageHandler(string message);
//Operation operation = delegate (int x, int y)
//{
//    return x + y;
//};
//Console.WriteLine(operation(6,9));
//delegate int Operation(int x,int y);

//лямбды
//var hello = () => Console.WriteLine("Hello");
//hello();
//Operation sum = (x, y) => Console.WriteLine(x + y);
//sum(4, 7);
//var msg = (string name) => Console.WriteLine(name);
//msg("Hello");
//var Sum = (int x, int y) => x + y;
//var Sub = (int x, int y) => x - y;
//Console.WriteLine(Sum(6,9));
//Console.WriteLine(Sub(6, 9));
//delegate void Message();
//delegate void Message1(string name);
//delegate void Operation(int x,int y);
//delegate int  Op(double x,double y);

//Лямбда-выражение как аргумент метода
Random random = new Random();
int[] integers = new int[random.Next(5, 20)];
for (int i = 0; i < integers.Length; i++) integers[i] = random.Next(10, 100);
//Console.WriteLine(SumGreat5(integers,8));
//Console.WriteLine(SumOdd(integers));

//int SumGreat5(int[] mas,int n)
//{
//    int s = 0;
//    foreach (int i in mas) if(i>n) s+= i;
//    return s;
//}
//int SumOdd(int[] mas)
//{
//    int s = 0;
//    foreach (int i in mas) if (i%2==0) s += i;
//    return s;
//}

//Console.WriteLine(Sum(integers, x => x > 5));
//Console.WriteLine(Sum(integers, x => x % 2 == 0));
//Console.WriteLine(Sum(integers, x => x % 5 == 0));
//int Sum(int[] mas, IsEqual func)
//{
//    int res = 0;
//    foreach (int i in mas)
//    {
//        if (func(i)) res += i;
//    }
//    return res;
//}
//delegate bool IsEqual(int x);

//Operation op = SelectOp(OperationType.Add);
//Console.WriteLine(op(6,9));
//Operation SelectOp(OperationType op){
//    switch (op)
//    {
//        case OperationType.Add:return (x, y) => x + y;
//        case OperationType.Sub: return (x, y) => x + y;
//        default:return (x, y) => x * y;
//    }
//}
//enum OperationType
//{
//    Add,Sub,Mult
//}
//delegate int Operation(int x,int y);

//Замыкание
//var fn = Outer();
//fn();
//fn();
//fn();

//Action Outer()
//{
//    int x = 5;
//    void Inner()
//    {
//        x++;
//        Console.WriteLine(x);
//    }
//    return Inner;
//}

//Контвариантность и ковариантность

//ковариантность
//EMailMessage WriteEMailMessage(string text) => new EMailMessage(text);
//MessageBuilder messageBuilder = WriteEMailMessage;
//Message message = messageBuilder("Hello");
//message.Print();
////Контвариантность
//void ReceiveMessage(Message message)=>message.Print();
//EmailReceiver emailBox=ReceiveMessage;
//emailBox(new EMailMessage("Hello"));

//class Message
//{
//    public string Text { get; }
//    public Message(string text)=>Text = text;
//    public virtual void Print()=>Console.WriteLine($"Message:{Text}");
//}
//class EMailMessage : Message
//{
//    public EMailMessage(string text) : base(text){}
//    public override void Print() => Console.WriteLine($"Email:{Text}");
//}
//class SMSMessage : Message
//{
//    public SMSMessage(string text) : base(text) { }
//    public override void Print() => Console.WriteLine($"SMS:{Text}");
//}
//delegate Message MessageBuilder(string text);
//delegate void EmailReceiver(EMailMessage text);

//Student[] group=new Student[3]{ 
//    new Student{FirstName="Антихрист",LastName="Никитин",
//        BirthDate=new DateTime(2006,3,11)},
//    new Student{FirstName="Мега",LastName="Бабаев",
//        BirthDate=new DateTime(2006,5,9)},
//    new Student{FirstName="Микро",LastName="Лавров",
//        BirthDate=new DateTime(2009,1,5)},
//};
//Teacher teacher= new Teacher();
//foreach (Student student in group)
//    teacher.examEvent += student.Exam;
////teacher.Exam("Физика");
////teacher.Exam("Математика");
////teacher.examEvent.Invoke("рейтинг");
////teacher.examEvent = null;
//teacher.Exam("Физика");
