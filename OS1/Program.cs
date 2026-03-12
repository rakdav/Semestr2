using System.Diagnostics;
using System.Reflection;
using System.Threading;

//Process current=Process.GetCurrentProcess();
//Console.WriteLine($"Id:{current.Id}");
//Console.WriteLine($"Name:{current.ProcessName}");
//Console.WriteLine($"Virtual memory:{current.VirtualMemorySize64}");
//Console.WriteLine($"MachineName:{current.MachineName}");
//Console.WriteLine($"MainModule:{current.MainModule}");
//Console.WriteLine($"Handle:{current.Handle}");
//Console.WriteLine($"StartTime:{current.StartTime}");
//Console.WriteLine($"PagedMemorySize64:{current.PagedMemorySize64}");

//foreach(Process process in Process.GetProcesses())
//{
//    Console.WriteLine(process.Id+" "+process.ProcessName);
//}
//Process[] mas=Process.GetProcessesByName("devenv");
//foreach(var proc in mas) Console.WriteLine(proc.Id);
//Process proc = Process.GetProcessesByName("devenv")[0];
//ProcessThreadCollection processThreads=proc.Threads;
//foreach(ProcessThread thread in processThreads)
//    Console.WriteLine(thread.Id+" "+thread.CurrentPriority+" "+thread.PriorityLevel+" "+thread.StartAddress+" "+thread.StartTime);

//ProcessModuleCollection modules=proc.Modules;
//foreach(ProcessModule module in modules)
//    Console.WriteLine(module.ModuleName+" "+module.FileName);

//Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome","https://mail.ru");
//ProcessStartInfo procInfo=new ProcessStartInfo();
//procInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome";
//procInfo.Arguments = "https://mail.ru";
//Process.Start(procInfo);
//AppDomain domain=AppDomain.CurrentDomain;
//Console.WriteLine(domain.FriendlyName);
//Console.WriteLine(domain.BaseDirectory);
//Assembly[] assemblies = domain.GetAssemblies();
//foreach (Assembly assembly in assemblies)
//    Console.WriteLine(assembly.GetName().Name);


//потоки 
//Thread currentThread = Thread.CurrentThread;
//Console.WriteLine(currentThread.Name);
//Console.WriteLine(currentThread.IsAlive);
//Console.WriteLine(currentThread.ManagedThreadId);
//Console.WriteLine(currentThread.ThreadState);
//currentThread.Name = "Nikitin";
//Console.WriteLine(currentThread.Name);
//Thread.Sleep(2000);
//Console.WriteLine("Hello");
//for (int i = 1; i < 61; i++)
//{
//    Console.WriteLine(i);
//    Thread.Sleep(1000);
//    Console.Clear();
//}
//void Print() => Console.WriteLine("Hello thread");
//Thread t1=new Thread(Print);
//Thread t2=new Thread(new ThreadStart(Print));
//Thread t3=new Thread(()=>Console.WriteLine("Hello"));
//t1.Start();
//t2.Start();
//t3.Start();
//1
//Thread thread = new Thread(Print);
//thread.Start();
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Главный поток:{i}");
//    Thread.Sleep(500);
//}

//void Print()
//{
//	for (int i = 0; i < 5; i++)
//	{
//        Console.WriteLine($"Второй поток:{i}");
//		Thread.Sleep(1000);
//	}
//}

//2-Потоки с параметрами и ParameterizedThreadStart

//Thread thread1 = new Thread(new ParameterizedThreadStart(Print));
//thread1.Start("Hello");
//Thread thread2=new Thread(PrintSquare);
//thread2.Start(6);

//void Print(object? message)=>Console.WriteLine(message);
//void PrintSquare(object? obj)
//{
//    if(obj is int n)
//    {
//        Console.WriteLine($"{n}*{n}={n*n}");
//    }
//}
//void PrintPerson(object? obj)
//{
//    if(obj is Person person)
//    {
//        Console.WriteLine($"Name={person.Name}");
//        Console.WriteLine($"Age={person.Age}");
//    }
//}
//record class Person(string Name,int Age);

//int x = 0;
//object locker=new();
//Lock locker=new Lock();
//AutoResetEvent waitHandler=new AutoResetEvent(true);
//Mutex mutex = new();
//for (int i = 1; i < 6; i++)
//{
//	Thread myThread = new Thread(Print);
//	myThread.Name = $"Поток {i}";
//	myThread.Start();
//}


void Print()
{
    //1-lock
    //lock (locker)
    //{
    //	//x = 1;
    //	for (int i = 1; i < 6; i++)
    //	{
    //		Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
    //		x++;
    //		Thread.Sleep(100);
    //	}
    //}
    //2-монитор
    //bool acquiredLock=false;
    //try
    //{
    //	Monitor.Enter(locker,ref acquiredLock);
    ////	x = 1;
    //	for (int i = 1; i < 6; i++)
    //	{
    //		Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
    //		x++;
    //		Thread.Sleep(100);
    //	}
    //}
    //   finally
    //{
    //	if(acquiredLock) Monitor.Exit(locker);
    //}
    //3
    //lock (locker)
    //{
    //    //x = 1;
    //    locker.Enter();
    //    try
    //    {
    //        for (int i = 1; i < 6; i++)
    //        {
    //            Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
    //            x++;
    //            Thread.Sleep(100);
    //        }
    //    }
    //    finally {  locker.Exit(); }
    //}
    //4-AutoResetEvent
    //Reset(): задает несигнальное состояние объекта, блокируя потоки.
    //Set(): задает сигнальное состояние объекта, позволяя одному или нескольким ожидающим потокам продолжить работу.
    //WaitOne(): задает несигнальное состояние и блокирует текущий поток, пока текущий объект AutoResetEvent не получит сигнал.

    //waitHandler.WaitOne();
    ////x = 1;
    //for (int i = 1; i < 6; i++)
    //{
    //    Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
    //    x++;
    //    Thread.Sleep(100);
    //}
    //waitHandler.Set();
    //mutex.WaitOne();
    ////x = 1;
    //for (int i = 1; i < 6; i++)
    //{
    //    Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
    //    x++;
    //    Thread.Sleep(100);
    //}
    //mutex.ReleaseMutex();

    //Семафор

}

for (int i = 1; i < 6; i++)
{
    Reader reader = new Reader(i);
}
public class Reader
{
    static Semaphore sem = new Semaphore(3, 3);
    Thread myThread;
    int count = 3;
    public Reader(int i)
    {
        myThread = new Thread(Read);
        myThread.Name = $"Читатель {i}";
        myThread.Start();
    }
    public void Read()
    {
        while (count > 0)
        {
            sem.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");
            Console.WriteLine($"{Thread.CurrentThread.Name} читает");
            Thread.Sleep(1000);
            Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");
            sem.Release();
            count--;
            Thread.Sleep(1000);
        }
    }
}
