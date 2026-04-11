
#region sintaksis

//1
//FileStream fs=null!;
//try
//{
//    fs = new FileStream("note3.dat",FileMode.OpenOrCreate);
//}
//catch (IOException)
//{

//}
//finally
//{
//    fs?.Close();
//}
//2
//using (FileStream fs=new FileStream("note3.dat", FileMode.OpenOrCreate))
//{

//}
#endregion

#region FileStreamDirectAccess
using System.Text;

//Console.Write("Введите текст:");
//string text=Console.ReadLine()!;
////запись в файл
//using (FileStream fs = new FileStream("text.txt", FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Default.GetBytes(text);
//    await fs.WriteAsync(buffer, 0, buffer.Length);
//}

//чтение из файла
//using (FileStream fs = File.OpenRead("text.txt"))
//{
//    byte[] buffer = new byte[fs.Length];
//    await fs.ReadAsync(buffer, 0, buffer.Length);
//    string text=Encoding.UTF8.GetString(buffer);
//    Console.WriteLine(text);
//}
#endregion

#region FileStreamRandomAccess
// чтение части файла
//using (FileStream fs=new FileStream("text.txt",FileMode.OpenOrCreate))
//{
//    fs.Seek(-5, SeekOrigin.End);
//    byte[] buffer = new byte[5];
//    await fs.ReadAsync(buffer, 0,buffer.Length);
//    string text = Encoding.UTF8.GetString(buffer);
//    Console.WriteLine(text);
//}
#endregion

#region TextFile
//Console.Write("Введите текст:");
//string text = Console.ReadLine()!;
// полная перезапись файла 
//using (StreamWriter writer=new StreamWriter("text.txt",false))
//{
//    await writer.WriteLineAsync(text);
//}    
// добавление в файл
//using (StreamWriter writer = new StreamWriter("text.txt", true))
//{
//    await writer.WriteLineAsync(text);
//}
//асинхронное чтение
// текст полностью
//using (StreamReader reader = new StreamReader("text.txt"))
//{
//    string allText=await reader.ReadToEndAsync();
//    Console.WriteLine(allText);
//}
//файл построчно
//using (StreamReader reader = new StreamReader("text.txt"))
//{
//    string? line;
//    while ((line = reader.ReadLine()) != null)
//    {
//        Console.WriteLine(line);
//    }
//}
#endregion

#region BinaryFile
//Person[] people= { 
//    new Person("Никитин",17,new DateOnly(2008,12,1)),
//    new Person("Лошариков",18,new DateOnly(2007,6,13))
//};
// сохраним в файл массив объектов
//using (BinaryWriter writer=new BinaryWriter(File.Open("people.dat",FileMode.OpenOrCreate)))
//{
//    foreach(Person person in people)
//    {
//        writer.Write(person.Name!);
//        writer.Write(person.Age);
//        writer.Write(person.Birthday.ToString());
//    }
//}

//List<Person> list=new List<Person>();
//using (BinaryReader reader = new BinaryReader(File.Open("people.dat", FileMode.Open)))
//{
//    while (reader.PeekChar() > -1)
//    {
//        string name=reader.ReadString();
//        int age=reader.ReadInt32();
//        DateOnly dateOnly=DateOnly.Parse(reader.ReadString());
//        list.Add(new Person(name,age,dateOnly));
//    }
//}
//foreach(Person p  in list)
//{
//    Console.WriteLine(p);
//}
//class Person
//{
//    public string? Name { get; set; }
//    public int Age { get; set; }
//    public DateOnly Birthday { get; set; }
//    public Person(string? name, int age, DateOnly birthday)
//    {
//        Name = name;
//        Age = age;
//        Birthday = birthday;
//    }
//    public override string? ToString()
//    {
//        return $"Name:{Name} Age:{Age} Birthday:{Birthday}";
//    }
//}
#endregion

#region Disk
//DriveInfo[] drives=DriveInfo.GetDrives();
//foreach (DriveInfo drive in drives)
//{
//    Console.WriteLine($"Название диска:{drive.Name}");
//    Console.WriteLine($"Тип диска:{drive.DriveType}");
//    if (drive.IsReady)
//    {
//        Console.WriteLine($"Объем диска:{drive.TotalSize}");
//        Console.WriteLine($"Свободное пространство:{drive.TotalFreeSpace}");
//        Console.WriteLine($"Метка диска:{drive.VolumeLabel}");
//    }
//    Console.WriteLine();
//}
#endregion

#region Directory
//string dirName1 = "C:\\";
//if (Directory.Exists(dirName1))
//{
//    Console.WriteLine("Подкаталоги:");
//    string[] dirs = Directory.GetDirectories(dirName1);
//    foreach (string dir in dirs) Console.WriteLine(dir);
//    Console.WriteLine();
//    Console.WriteLine("Файлы:");
//    string[] files = Directory.GetFiles(dirName1);
//    foreach (string file in files) Console.WriteLine(file);
//}
////Фильтрация папок и файлов
//string[] dirs1=Directory.GetDirectories(dirName1,"P*.");
//foreach (string file in dirs1) Console.WriteLine(file);
//string[] files1 = Directory.GetFiles(dirName1, ".exe");
//foreach (string file in files1) Console.WriteLine(file);
//Создание каталога
//string path1 = @"G:\ЛысыйНикитин";
//if(!Directory.Exists(path1)) Directory.CreateDirectory(path1);
//if (Directory.Exists(@"G:\Nikitin"))
//    Directory.Delete(@"G:\Nikitin");
//else Console.WriteLine("Каталога нет");
#endregion

#region DirectoryInfo
//string dirName2 = "C:\\";
//var directory=new DirectoryInfo(dirName2);
//if (directory.Exists)
//{
//    Console.WriteLine("Подкаталоги:");
//    DirectoryInfo[] dirs = directory.GetDirectories();
//    foreach (DirectoryInfo dir in dirs) Console.WriteLine(dir);
//    Console.WriteLine();
//    Console.WriteLine("Файлы:");
//    FileInfo[] files = directory.GetFiles();
//    foreach (FileInfo file in files) Console.WriteLine(file);
//}
////Фильтрация папок и файлов
//var dir2 = new DirectoryInfo(dirName2);
//DirectoryInfo[] dirsFind = directory.GetDirectories("P*.");
//foreach (DirectoryInfo file in dirsFind) Console.WriteLine(file);
//FileInfo[] files2=dir2.GetFiles("*.exe");
//foreach (FileInfo file in files2) Console.WriteLine(file);
//string path1 = @"G:\ЛысыйНикитин";
//DirectoryInfo dir1 = new DirectoryInfo(path1);
//if(!dir1.Exists) dir1.Create();
//string path1 = @"C:\Program Files";
//DirectoryInfo dirInfo = new DirectoryInfo(path1);
//Console.WriteLine($"Название {dirInfo.Name}");
//Console.WriteLine($"Полное название {dirInfo.FullName}");
//Console.WriteLine($"Время создание {dirInfo.CreationTime}");
//Console.WriteLine($"Корневой каталог {dirInfo.Root}");
//DirectoryInfo dir = new DirectoryInfo(@"G:\Nikitin");
//if(dir.Exists) dir.Delete();
//else Console.WriteLine("Каталога нет");
string oldPath = @"G:\SomeFolder";
string newPath = @"G:\SomeDir";
DirectoryInfo dir = new DirectoryInfo(oldPath);
if (dir.Exists&&!Directory.Exists(newPath)) dir.MoveTo(newPath);
#endregion

#region File

#endregion

#region FileInfo

#endregion