//1
Task task1 = new Task(()=> Console.WriteLine("Hello Task!"));
task1.Start();
//2
Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello Task!"));
//3
Task task3 = Task.Run(() => Console.WriteLine("Hello Task!"));

task1.Wait();
task2.Wait();
task3.Wait();
//асинхронно
Console.WriteLine("Main Starts");
Task task4 = new Task(() =>
{
    Console.WriteLine("Task Starts");
    Thread.Sleep(1000);
    Console.WriteLine("Task Ends");
});
Console.WriteLine("Main Ends");
task4.Start();
task4.Wait();
//синхронно
Console.WriteLine("Main Starts");
Task task5 = new Task(() =>
{
    Console.WriteLine("Task Starts");
    Thread.Sleep(1000);
    Console.WriteLine("Task Ends");
});
Console.WriteLine("Main Ends");
task5.RunSynchronously();
//свойства Task
Task task6 = new Task(() =>
{
    Console.WriteLine($"Task {Task.CurrentId} Starts");
    Thread.Sleep(1000);
    Console.WriteLine($"Task {Task.CurrentId} Ends");
});
task6.Start();
Console.WriteLine(task6.Id);
Console.WriteLine(task6.IsCompleted);
Console.WriteLine(task6.IsCanceled);
Console.WriteLine(task6.IsFaulted);
Console.WriteLine(task6.Status);