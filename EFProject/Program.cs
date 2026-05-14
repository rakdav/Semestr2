using EFProject;
using Faker;
using Microsoft.EntityFrameworkCore;

using (DbShopContext db=new DbShopContext())
{
    #region Create
    //Client client = new Client();
    //client.CityClient = "Москва";
    //client.Email = "Yuliy@mail.ru";
    //client.FirstName = "Юлий";
    //client.LastName = "Цезаревич";
    //client.SurName = "Саржинский";
    //client.Firma = "Одни копыта";
    //client.Phone = "+78009675643";
    //db.Clients.Add(client);
    //await db.SaveChangesAsync();

    //Product product=new Product();
    //product.NameProduct = "Овес";
    //product.CityProduct = "Цезарь сити";
    //product.Remainder = 30;
    //product.Sort = "Высший";
    //product.Type = "Для лошадей";
    //   db.Products.Add(product);
    //   await db.SaveChangesAsync();

    //Sdelka sdelka=new Sdelka();
    //sdelka.DateSale = DateTime.Now.ToString();
    //sdelka.Count = 4;
    //sdelka.IdClientNavigation = client;
    //sdelka.IdProductNavigation = product;
    //   db.Sdelkas.Add(sdelka);
    //   await db.SaveChangesAsync();
    //for (int i = 0; i < 5; i++)
    //{
    //    Client client = new Client();
    //    client.CityClient = Faker.Address.City();
    //    client.Email = Faker.Internet.Email();
    //    client.FirstName = Faker.Name.First();
    //    client.LastName = Faker.Name.Last();
    //    client.SurName = Faker.Name.Middle();
    //    client.Firma = Faker.Company.Name();
    //    client.Phone = Faker.Phone.Number();
    //    db.Clients.Add(client);
    //    await db.SaveChangesAsync();

    //    Product product = new Product();
    //    product.NameProduct = Faker.Name.First();
    //    product.CityProduct = Faker.Address.City();
    //    product.Remainder = Faker.RandomNumber.Next(1,200);
    //    product.Sort = Faker.Lorem.Sentence(5);
    //    product.Type = Faker.Lorem.Sentence(5);
    //    db.Products.Add(product);
    //    await db.SaveChangesAsync();

    //    Sdelka sdelka = new Sdelka();
    //    sdelka.DateSale = DateTime.Now.ToString();
    //    sdelka.Count = Faker.RandomNumber.Next(1, 10);
    //    sdelka.IdClientNavigation = client;
    //    sdelka.IdProductNavigation = product;
    //    db.Sdelkas.Add(sdelka);
    //    await db.SaveChangesAsync();
    //}
    #endregion

    //#region Read
    //List<Product> productList=db.Products.ToList();
    //foreach (Product product in productList)
    //{
    //    Console.WriteLine(product);
    //}
    //#endregion

    #region Update
    //Client client = db.Clients.FirstOrDefault(p=>p.IdClient==4)!;
    //client.SurName = "Суслик";
    //await db.SaveChangesAsync();
    #endregion

    #region Delete
    //Client client = db.Clients.FirstOrDefault(p => p.IdClient == 4)!;
    //db.Clients.Remove(client);
    //await db.SaveChangesAsync();
    #endregion

    #region Select
    // SELECT * FROM Клиент
    //List<Client> clients = db.Clients.ToList();
    //foreach (Client client in clients)
    //{
    //Console.WriteLine(client.FirstName+" "+client.SurName+" "+client.LastName+" "+client.Firma+" "+
    //    client.Email+" "+client.CityClient+" "+client.Phone);
    //}

    //SELECT Клиент.Фирма FROM Клиент
    //var firms = db.Clients.Select(p => new {Firma=p.Firma });
    //foreach (var client in firms)
    //{
    //    Console.WriteLine(client.Firma);
    //}

    //SELECT DISTINCT Клиент.Фирма FROM Клиент
    //var firmsDist = db.Clients.Select(p => new { Firma = p.Firma }).Distinct();
    //foreach (var client in firmsDist)
    //{
    //    Console.WriteLine(client.Firma);
    //}

    //SELECT * FROM Сделка WHERE Количество> 20
    //var clients = db.Sdelkas.Where(p => p.Count > 5);
    //foreach (var client in clients)
    //{
    //    Console.WriteLine(client.DateSale+" "+client.Count);
    //}

    //SELECT Название, Цена FROM Товар WHERE Цена>= 100 And Цена<=1500
    //var sdelkas = db.Products.Where(p => p.Price > 100 && p.Price < 1500);
    //foreach (var client in sdelkas)
    //{
    //    Console.WriteLine(client.NameProduct + " " + client.Price);
    //}

    //SELECT Фамилия, ГородКлиента FROM Клиент WHERE ГородКлиента = "South Keely" Or ГородКлиента = "Effertzshire"
    //var sdelkas = db.Clients.Where(p => p.CityClient== "South Keely"||p.CityClient== "Effertzshire");
    //foreach (var client in sdelkas)
    //{
    //    Console.WriteLine(client.Firma + " " + client.FirstName+" "+client.CityClient);
    //}

    //SELECT Клиент.Фамилия, Клиент.Телефон FROM Клиент WHERE Клиент.Телефон LIKE '_-%'
    //var clients = db.Clients.Where(p => EF.Functions.Like(p.Phone,"_-%"));
    //foreach (var client in clients)
    //{
    //    Console.WriteLine(client.Firma + " " + client.FirstName + " " + client.CityClient);
    //}
    //SELECT Клиент.Фамилия, Клиент.Телефон FROM Клиент WHERE Клиент.Телефон LIKE '_[2,4]%'
    //var clients = db.Clients.Where(p => EF.Functions.Like(p.Phone, "_-%")|| EF.Functions.Like(p.Phone, "_5%"));
    //foreach (var client in clients)
    //{
    //    Console.WriteLine(client.Firma + " " + client.FirstName + " " + client.CityClient);
    //}
    //SELECT Клиент.Фамилия FROM Клиен WHERE Клиент.Фамилия LIKE "%ро%"
    //var clients = db.Clients.Where(p => p.FirstName.Contains("gu"));
    //foreach (var client in clients)
    //{
    //    Console.WriteLine(client.Firma + " " + client.FirstName + " " + client.CityClient);
    //}
    //SELECT Фамилия, Телефон FROM Клиенn WHERE Телефон IS NULL
    //var clients = db.Clients.Where(p => p.Phone!=null);
    //foreach (var client in clients)
    //{
    //    Console.WriteLine(client.Firma + " " + client.FirstName + " " + client.CityClient);
    //}

    //SELECT Клиент.Фамилия, Клиент.Фирма FROM Клиент ORDER BY Клиент.Фамилия
    //var clients = db.Clients.Select(p => new { Surname = p.SurName, Firma = p.Firma }).OrderByDescending(p=>p.Surname);
    //foreach (var client in clients)
    //{
    //    Console.WriteLine(client.Firma + ":" + client.Surname);
    //}
    //var sdelki = from sdelks in db.Sdelkas
    //             join client in db.Clients on sdelks.IdClient equals client.IdClient
    //             join product in db.Products on sdelks.IdProduct equals product.IdProduct
    //             select new
    //             {
    //                 FIO = client.FirstName + " " + client.LastName + " " + client.SurName,
    //                 Product= product.NameProduct,
    //                 Quantity=sdelks.Count,
    //                 Date=sdelks.DateSale
    //             };
    //foreach(var s in sdelki)
    //{
    //    Console.WriteLine(s.FIO+" "+s.Product+" "+s.Quantity+" "+s.Date);
    //}

    // Рассчитать общую стоимость для каждой сделки.
    //var sdelka = db.Sdelkas.Join(db.Products,
    //    u=>u.IdProduct,
    //    c=>c.IdProduct,
    //    (u, c) => new
    //    {
    //        Name=c.NameProduct,
    //        Date=u.DateSale,
    //        Sum=u.Count*c.Price
    //    });
    //foreach (var s in sdelka)
    //{
    //    Console.WriteLine(s.Name + " " + s.Date + " " + s.Sum);
    //}

    //Получить список фирм с указанием фамилии и инициалов клиентов.
    //var clients = db.Clients.Select(p => new {Firma=p.Firma, FIO=p.SurName+" "+p.FirstName.Substring(0,1)+"."+p.LastName!.Substring(0,1)+"." });
    //foreach (var s in clients)
    //{
    //    Console.WriteLine(s.Firma + " " + s.FIO);
    //}

    // Получить список товаров с указанием года и месяца продажи.
    //var products=db.Sdelkas.Join(db.Products,
    //    u=>u.IdProduct,
    //    c=>c.IdProduct,
    //    (u,c)=>new
    //    {
    //        Name=c.NameProduct,
    //        Year=DateTime.Parse(u.DateSale).Year,
    //        Month= DateTime.Parse(u.DateSale).Month
    //    });
    //foreach (var s in products)
    //{
    //    Console.WriteLine(s.Name + " " + s.Year+" "+s.Month);
    //}

    //Определить первое по алфавиту название товара.
    //var spisok = db.Products.Min(p=>p.NameProduct);
    //Console.WriteLine(spisok);

    //Определить количество сделок.
    //var suantity = db.Sdelkas.Count();
    //Console.WriteLine(suantity);

    //Определить суммарное количество проданного товара.
    //var sum = db.Sdelkas.Sum(p=>p.Count);
    //Console.WriteLine(sum);


    //Определить среднюю цену проданного товара.
    //var avg = db.Sdelkas.Join(db.Products,
    //    u => u.IdProduct,
    //    c => c.IdProduct,
    //    (u, c) => new
    //    {
    //        avg=c.Price
    //    }).Average(p=>p.avg);
    //Console.WriteLine(avg);

    //Подсчитать общую стоимость проданных товаров.
    //var total = db.Sdelkas.Join(db.Products,
    //    u => u.IdProduct,
    //    c => c.IdProduct,
    //    (u, c) => new
    //    {
    //        Total = c.Price*u.Count
    //    }).Sum(p=>p.Total);
    //Console.WriteLine(total);
    //Group by
    //Вычислить средний объем покупок, совершенных каждым покупателем.
    //var avgClients = db.Sdelkas.GroupBy(u => u.IdClient).Select(g => new
    //{
    //    Surnane=db.Clients.Where(p=>p.IdClient==g.Key).FirstOrDefault()!.SurName,
    //    Avg=g.Average(p=>p.Count)
    //});
    //foreach (var client in avgClients)
    //{
    //    Console.WriteLine(client.Surnane+" "+client.Avg);
    //}
    //Определить, на какую сумму был продан товар каждого наименования.
    //var sumClients = db.Sdelkas.GroupBy(u => u.IdProduct).Select(g =>
    //new
    //{
    //    Name=db.Products.Where(p=>p.IdProduct==g.Key).FirstOrDefault()!.NameProduct,
    //    Sum=g.Sum(p=>p.Count* db.Products.Where(p => p.IdProduct == g.Key).FirstOrDefault()!.Price)
    //});
    //foreach (var client in sumClients)
    //{
    //    Console.WriteLine(client.Name + " " + client.Sum);
    //}
    //Подсчитать количество сделок, осуществленных каждой фирмой
    var result = db.Clients.Join(db.Sdelkas,
        c => c.IdClient,
        s => s.IdClient,
        (c, s) => new { c, s }).GroupBy(p => p.c.Firma).Select(g=>new
        {
            Firma=g.Key,
            Quantity=g.Count(),
        });
    foreach (var client in result)
    {
        Console.WriteLine(client.Firma + " " + client.Quantity);
    }
    #endregion

}
