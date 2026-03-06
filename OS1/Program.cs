using System.Diagnostics;
using System.Reflection;

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
Thread thread = new Thread(Print);
thread.Start();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Главный поток:{i}");
    Thread.Sleep(500);
}

void Print()
{
	for (int i = 0; i < 5; i++)
	{
        Console.WriteLine($"Второй поток:{i}");
		Thread.Sleep(1000);
	}
}



