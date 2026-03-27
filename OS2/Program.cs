//1
//Task task1 = new Task(()=> Console.WriteLine("Hello Task!"));
//task1.Start();
////2
//Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello Task!"));
////3
//Task task3 = Task.Run(() => Console.WriteLine("Hello Task!"));

//task1.Wait();
//task2.Wait();
//task3.Wait();
////асинхронно
//Console.WriteLine("Main Starts");
//Task task4 = new Task(() =>
//{
//    Console.WriteLine("Task Starts");
//    Thread.Sleep(1000);
//    Console.WriteLine("Task Ends");
//});
//Console.WriteLine("Main Ends");
//task4.Start();
//task4.Wait();
////синхронно
//Console.WriteLine("Main Starts");
//Task task5 = new Task(() =>
//{
//    Console.WriteLine("Task Starts");
//    Thread.Sleep(1000);
//    Console.WriteLine("Task Ends");
//});
//Console.WriteLine("Main Ends");
//task5.RunSynchronously();
////свойства Task
//Task task6 = new Task(() =>
//{
//    Console.WriteLine($"Task {Task.CurrentId} Starts");
//    Thread.Sleep(1000);
//    Console.WriteLine($"Task {Task.CurrentId} Ends");
//});
//task6.Start();
//Console.WriteLine(task6.Id);
//Console.WriteLine(task6.IsCompleted);
//Console.WriteLine(task6.IsCanceled);
//Console.WriteLine(task6.IsFaulted);
//Console.WriteLine(task6.Status);

//вложенные задачи
//var outer = Task.Factory.StartNew(() =>
//{
//    Console.WriteLine("Outer");
//    var inner = Task.Factory.StartNew(() => {
//        Console.WriteLine("Inner start");
//        Thread.Sleep(2000);
//        Console.WriteLine("Inner stop");
//    },TaskCreationOptions.AttachedToParent);
//});
//outer.Wait();

//массив задач
//Task[] tasks = new Task[3]
//{
//    new Task(()=>Console.WriteLine("task1")),
//    new Task(()=>Console.WriteLine("task2")),
//    new Task(()=>Console.WriteLine("task3"))
//};
//foreach (var task in tasks)
//    task.Start();
//Task.WaitAll(tasks);

//возвращение результата
//Console.Write("Введите первое число:");
//int n1=int.Parse(Console.ReadLine()!);
//Console.Write("Введите второе число:");
//int n2 = int.Parse(Console.ReadLine()!);
//Task<int> sumTask = new Task<int>(()=>Sum(n1,n2));
//sumTask.Start();
//Console.WriteLine($"{n1}+{n2}={sumTask.Result}");
//int Sum(int a, int b) => a + b;

//Задачи продолжения
//Task task1 = new Task(() =>
//{
//    Console.WriteLine($"Id задачи:{Task.CurrentId}");
//});
//Task task2 = task1.ContinueWith(PrintTask);
//task1.Start();
//task2.Wait();

//void PrintTask(Task t)
//{
//    Console.WriteLine($"Id Задачи:{Task.CurrentId}");
//    Console.WriteLine($"Id предыдущей задачи:{t.Id}");
//    Thread.Sleep(3000);
//}
//Console.Write("Введите кординату x1 точки:");
//double x1 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите кординату y1 точки:");
//double y1 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите кординату x2 точки:");
//double x2 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите кординату y2 точки:");
//double y2 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите кординату x3 точки:");
//double x3 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите кординату y3 точки:");
//double y3 = double.Parse(Console.ReadLine()!);
//Task<double> task1 =Task.Run(()=>Side(x1,y1,x2,y2));
//Task<double> task2 = Task.Run(() => Side(x2, y2, x3, y3));
//Task<double> task3 = Task.Run(() => Side(x1, y1, x3, y3));
//Task<double> task4 = Task.Run(() =>Area(task1.Result,task2.Result,task3.Result));
//Console.WriteLine($"{task4.Result:F2}");
//double Side(double x1, double y1, double x2, double y2)=>Math.Sqrt(x1 * x1 + y1 * y2);
//double Area(double a,double b,double c)
//{
//    double pp = (a + b + c) / 2;
//    return Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c));
//}

//Класс Parallel
//Parallel.Invoke(
//    Print,
//    () =>
//    {
//        Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//        Thread.Sleep(3000);
//    },
//    ()=>Square(5)
//    );

//Parallel.For
//Parallel.For(1, 5, Square);
//Parallel.ForEach
//ParallelLoopResult result = Parallel.ForEach<int>(
//    new List<int>() { 1, 3, 5, 7 },
//    Square);
//if(!result.IsCompleted)
//    Console.WriteLine($"Выполнение цикла завершено на итерации {result.LowestBreakIteration}");
//void Print()
//{
//    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//    Thread.Sleep(3000);
//}

//void Square(int n,ParallelLoopState pls)
//{
//    if(n==5) pls.Break();
//    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//    Thread.Sleep(3000);
//    Console.WriteLine($"Результат {n * n}");
//}


