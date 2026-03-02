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
AppDomain domain=AppDomain.CurrentDomain;
Console.WriteLine(domain.FriendlyName);
Console.WriteLine(domain.BaseDirectory);
Assembly[] assemblies = domain.GetAssemblies();
foreach (Assembly assembly in assemblies)
    Console.WriteLine(assembly.GetName().Name);

