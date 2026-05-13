using EFProject;
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
    var clients = db.Clients.Where(p => p.Phone!=null);
    foreach (var client in clients)
    {
        Console.WriteLine(client.Firma + " " + client.FirstName + " " + client.CityClient);
    }
    #endregion

}
